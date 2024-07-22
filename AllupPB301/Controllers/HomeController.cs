using AllupPB301.Data;
using AllupPB301.Models;
using AllupPB301.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AllupPB301.Controllers
{
    public class HomeController : Controller
    {
        private readonly AllUpDbContext _context;

        public HomeController(AllUpDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM HomeVM = new();
            HomeVM.Sliders = await _context.Sliders.Where(s=>!s.IsDeleted).ToListAsync();
            HomeVM.Categories = await _context.Categories.Where(s => !s.IsDeleted && s.IsMain).ToListAsync();
            HomeVM.BestSellerProducts = await _context.Products.Where(p => !p.IsDeleted && p.isBestSeller).ToListAsync();
            HomeVM.NewProducts = await _context.Products.Where(p => !p.IsDeleted && p.isNewArrival).ToListAsync();
            HomeVM.FeaturedProducts = await _context.Products.Where(p => !p.IsDeleted && p.isFeatured).ToListAsync();

            return View(HomeVM);
        }
    }
}

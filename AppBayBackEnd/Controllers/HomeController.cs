using AppBayBackEnd.DAL;
using AppBayBackEnd.Models;
using AppBayBackEnd.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AppBayBackEnd.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.sliders= _context.Slider.FirstOrDefault();
            homeVM.cards=_context.Card.ToList();
            homeVM.modernCard=_context.ModernCard.ToList();

            return View(homeVM);
        }
    }
}

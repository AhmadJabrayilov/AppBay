using AppBayBackEnd.DAL;
using AppBayBackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppBayBackEnd.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CardController : Controller
    {
        
        private AppDbContext _context;
        public CardController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            List<Card> card = _context.Card.ToList();
            return View(card);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id==null)
                return NotFound();
            Card card =await _context.Card.FindAsync(id);
            if (card==null) return NotFound();
            return View(card);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id==null)
                return NotFound();
            Card card = await _context.Card.FindAsync(id);
            if (card==null) return NotFound();
            _context.Card.Remove(card);
           await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Card card)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Card newCard = new Card();
            newCard.CardIcon = card.CardIcon;
            newCard.CardTitle = card.CardTitle;
            newCard.CardDesc = card.CardDesc;
            await _context.AddAsync(newCard);
            await _context.SaveChangesAsync();

                
            return View();
        }
    }
}

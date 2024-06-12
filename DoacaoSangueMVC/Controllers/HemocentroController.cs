using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoacaoSangueMVC.Data;
using DoacaoSangueMVC.Entities;

namespace DoacaoSangueMVC.Controllers
{
    public class HemocentroController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HemocentroController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Hemocentroe
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hemocentros.ToListAsync());
        }

        // GET: Hemocentroe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hemocentro = await _context.Hemocentros
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hemocentro == null)
            {
                return NotFound();
            }

            return View(hemocentro);
        }
    }  
}

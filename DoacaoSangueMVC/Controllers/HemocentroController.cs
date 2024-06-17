using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DoacaoSangueMVC.Data;
using DoacaoSangueMVC.Entities;
using DoacaoSangueMVC.Models;
using System.Text;
using DoacaoSangueMVC.WorkService.Hemocentro;
using Microsoft.AspNetCore.Mvc.Routing;

namespace DoacaoSangueMVC.Controllers
{
    public class HemocentroController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly HemocentroWorkService _workService;

        public HemocentroController(ApplicationDbContext context, HemocentroWorkService workService)
        {
            _context = context;
            _workService = workService;
        }

        // GET: Hemocentroe
        public async Task<IActionResult> Index()
        {
            var viewModel = _workService.MapeamentoParaHemocentroDTOS();
            return View(await viewModel);
        }

        public async Task<IActionResult> BancoSangue(int? id)
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
            
            var bancoDeSangueDTOs = await _workService.MapeamentoParaBancoDeSangueDTOs(hemocentro);

            return View(bancoDeSangueDTOs);
        }// GET: Hemocentroe/Details/5
        public IActionResult Agendamento()
        {
            return View();
        }

        public async Task<IActionResult> Agendar(AgendamentoDTO model)
        {
            _workService.APIWeebHookMSGWPP();
            return RedirectToAction("Index");
           
        }
    }
}

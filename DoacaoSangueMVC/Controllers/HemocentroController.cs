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
            ViewBag.NomeHemocentro = hemocentro.Nome;
            return View(bancoDeSangueDTOs);
        }
        public async Task<IActionResult> Agendamento(int id)
        {
            AgendamentoDTO agendamentoDTO = new AgendamentoDTO();
            var query = await _context.Hemocentros.Where(m => m.Id == id).FirstOrDefaultAsync();
            agendamentoDTO.NomeHemocentro = query.Nome;
            agendamentoDTO.IdHemocentro = query.Id;
            agendamentoDTO.data = new System.DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            return View(agendamentoDTO);
        }

        public async Task<IActionResult> Agendar(AgendamentoDTO model)
        {
            var query = await _workService.CriarAgendamentoDoacao(model.hora, model.data, model.AuthenticationTypeUser, model.IdHemocentro);
            _workService.APIWeebHookMSGWPP(model);
            return RedirectToAction("Index");
           
        }
    }
}

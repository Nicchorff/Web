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
            //string url = "https://webhook.app.hubhero.com.br/webhook/48ec13d5-039b-4df0-9c9e-b20c40c76806";

            //var data = new
            //{
            //    nome = "Érico",
            //    idade = 20

            //};

            //var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            //var content = new StringContent(json, Encoding.UTF8, "application/json");

            //// Criar uma instância de HttpClient
            //using (HttpClient client = new HttpClient())
            //{
            //    try
            //    {
            //        // Enviar a requisição POST
            //        HttpResponseMessage response = await client.PostAsync(url, content);

            //        // Ler a resposta da requisição
            //        string responseBody = await response.Content.ReadAsStringAsync();

            //        // Verificar se a requisição foi bem-sucedida
            //        if (response.IsSuccessStatusCode)
            //        {
            //            Console.WriteLine("Requisição POST enviada com sucesso!");
            //            Console.WriteLine("Resposta do servidor: " + responseBody);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Erro ao enviar a requisição POST.");
            //            Console.WriteLine("Status Code: " + response.StatusCode);
            //            Console.WriteLine("Resposta do servidor: " + responseBody);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Ocorreu um erro ao enviar a requisição POST:");
            //        Console.WriteLine(ex.Message);
            //    }

                return RedirectToAction("Index");
           
        }
    }
}

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
        }// GET: Hemocentroe/Details/5
        public async Task<IActionResult> Agendamento()
        {
            return View();
        }

        public async Task<IActionResult> Agendar(AgendamentoDTO model)
        {
            string url = "https://webhook.app.hubhero.com.br/webhook/48ec13d5-039b-4df0-9c9e-b20c40c76806";

            var data = new
            {
                nome = "Érico",
                idade = 20

            };

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Criar uma instância de HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Enviar a requisição POST
                    HttpResponseMessage response = await client.PostAsync(url, content);

                    // Ler a resposta da requisição
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Verificar se a requisição foi bem-sucedida
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Requisição POST enviada com sucesso!");
                        Console.WriteLine("Resposta do servidor: " + responseBody);
                    }
                    else
                    {
                        Console.WriteLine("Erro ao enviar a requisição POST.");
                        Console.WriteLine("Status Code: " + response.StatusCode);
                        Console.WriteLine("Resposta do servidor: " + responseBody);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao enviar a requisição POST:");
                    Console.WriteLine(ex.Message);
                }

                return RedirectToAction("Index");
            }
        }
    }
}

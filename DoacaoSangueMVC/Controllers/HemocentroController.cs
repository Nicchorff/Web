using DoacaoSangueMVC.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DoacaoSangueMVC.Controllers
{

    public class HemocentroController : Controller
    {
        Hemocentro hemocentro1 = new Hemocentro
        {
            Id = 1,
            Nome = "Hemocentro Central",
            CEP = 12345.678,
            Referencia = "Near Central Park",
            NomeHemocentro = "Central Blood Bank",
            Telefone = 1234567890,
            Email = "central@hemocentro.com",
            Endereco = "123 Central St, Central City"
        };

        // Create second object
        Hemocentro hemocentro2 = new Hemocentro
        {
            Id = 2,
            Nome = "Hemocentro Norte",
            CEP = 98765.432,
            Referencia = "Next to North Hospital",
            NomeHemocentro = "North Blood Bank",
            Telefone = 0987654321,
            Email = "north@hemocentro.com",
            Endereco = "456 North Ave, Northern City"
        };

        public IActionResult Index()
        {
            List<Hemocentro> model = new List<Hemocentro>();   
            model.Add(hemocentro1);
            model.Add(hemocentro2);


            return View(model);
        }

        public IActionResult BancoSangue(int id)
        {
            List<Hemocentro> model = new List<Hemocentro>();
            model.Add(hemocentro1);
            model.Add(hemocentro2);
            foreach(var iten in model)
            {
                if (iten.Id == id)
                {
                    return View();
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult Agendamento(int id)
        {
            List<Hemocentro> model = new List<Hemocentro>();
            model.Add(hemocentro1);
            model.Add(hemocentro2);
            foreach (var iten in model)
            {
                if (iten.Id == id)
                {
                    return View();
                }
            }
            return RedirectToAction("Index");
        }
    }
}

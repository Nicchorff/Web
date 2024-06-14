using DoacaoSangueMVC.Data;
using DoacaoSangueMVC.Models;

namespace DoacaoSangueMVC.WorkService.Hemocentro
{
    public class HemocentroWorkService
    {
        private readonly ApplicationDbContext _context;

        public HemocentroWorkService(ApplicationDbContext context)
        {
            _context = context;
        }



        public double TirarMediaDoTotalDeSangue(double quantidadeDeSangueHemocentro)
        {
            if (quantidadeDeSangueHemocentro > 0)
            {
                return quantidadeDeSangueHemocentro / 1000;
            }
           
            return 0;
        } 

    }
}

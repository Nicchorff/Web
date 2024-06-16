//TODO - Buscar Quantidade total no estoque

using DoacaoSangueMVC.Data;
using DoacaoSangueMVC.Entities;
using DoacaoSangueMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DoacaoSangueMVC.WorkService.Hemocentro
{
    public class HemocentroWorkService
    {
        private readonly ApplicationDbContext _context;

        public HemocentroWorkService(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public async Task<ICollection<BancoDeSangueDTO>> MapeamentoParaBancoDeSangueDTOs(Entities.Hemocentro hemocentro)
        {
            var bancoDeSangueDTOs = new List<BancoDeSangueDTO>();
            var listaTipossanguineos = await ListaDeTiposSanguineosAsync();
            foreach (var iten in listaTipossanguineos) 
            {
                var bancoDeSangueDTO = new BancoDeSangueDTO();
                bancoDeSangueDTO.TipoSanguineo = iten;
                bancoDeSangueDTO.NomeHemocentro = hemocentro.Nome;  
                var listaComTodoVolumeColetado = await BuscarTipoSanguineosDeDoadoresNoHemocentro(iten.ID, hemocentro.Id);
                var valorComTodosOsVolumesSomados = CalcularTotalDeSangue(listaComTodoVolumeColetado);
                bancoDeSangueDTO.QuantidadeNoEstoque = ConvertMlToL(valorComTodosOsVolumesSomados);   
                bancoDeSangueDTO.MediaDeSangueNoEstoque = TirarMediaDoTotalDeSangue(valorComTodosOsVolumesSomados);
                bancoDeSangueDTOs.Add(bancoDeSangueDTO);
            }

            return bancoDeSangueDTOs;
        }

        private async Task<IList<int>> BuscarTipoSanguineosDeDoadoresNoHemocentro(int idtipoSanguineo, int idDoHemocentro)
        {
            return await _context.Doadores.Where(x => x.IdTipoSanguineo ==  idtipoSanguineo)
                .Join(_context.SangueColetados.Where(sc => sc.IdHemocentro == idDoHemocentro),
                    doador => doador.Id,
                    sangueColetado => sangueColetado.IdDoacao,
                    (doador, sangueColetado) => doador.VolumeColetado)
                .ToListAsync();
        }

        private int CalcularTotalDeSangue(IList<int> volumesColetados)
        {
            var resultado = 0;
            foreach(var item in volumesColetados)
            {
                resultado += item;
            }
            return resultado;

        }



        private async Task<IList<ABO>> ListaDeTiposSanguineosAsync()
        {
            return await _context.TiposSanguineos.ToListAsync();
        }

        private double TirarMediaDoTotalDeSangue(double quantidadeDeSangueHemocentro)
        {
            var convertidoParaLitros = ConvertMlToL(quantidadeDeSangueHemocentro);

            if (convertidoParaLitros > 0)
            {
                return convertidoParaLitros /*/ 1000*/;
            }
           
            return 0;
        } 

        private double ConvertMlToL(double ml)
        {
            return ml / 10;
        }   

    }
}

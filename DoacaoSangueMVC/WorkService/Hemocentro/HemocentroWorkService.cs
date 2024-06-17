//TODO - Buscar Quantidade total no estoque

using DoacaoSangueMVC.Data;
using DoacaoSangueMVC.Entities;
using DoacaoSangueMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

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

        public async Task<ICollection<HemocentroDTO>> MapeamentoParaHemocentroDTOS()
        {
            var listaTipossanguineos = await ListaDeTiposSanguineosAsync();
            var listaComHemocentros = await _context.Hemocentros.ToListAsync();
            var hemocentroDTOs = new List<HemocentroDTO>();
            var bancoDeSangueDTO = new BancoDeSangueDTO();

            foreach (var iten in listaComHemocentros)
            {
                var hemocentroDTO = new HemocentroDTO();
                IList<string> listaComOsTipoSanguineoFaltando = new List<string>();
                hemocentroDTO.Hemocentro = iten;
                foreach (var item in listaTipossanguineos)
                {
                    var listaComTodoVolumeColetado = await BuscarTipoSanguineosDeDoadoresNoHemocentro(item.ID, iten.Id);
                    var valorComTodosOsVolumesSomados = CalcularTotalDeSangue(listaComTodoVolumeColetado);
                    var mediaColetados = TirarMediaDoTotalDeSangue(valorComTodosOsVolumesSomados);
                    if (mediaColetados < bancoDeSangueDTO.QuantidadeMinímaSugerida)
                    {
                        listaComOsTipoSanguineoFaltando.Add($"{item.TipoSanguineo} {(item.IsPositivo ? "+" : "-")}");
                    }
                }
                hemocentroDTO.TipoSanguineoFaltando = listaComOsTipoSanguineoFaltando;
                hemocentroDTOs.Add(hemocentroDTO);
            }

            return hemocentroDTOs;
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

        public async void APIWeebHookMSGWPP()
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

            }
        }

    }
}

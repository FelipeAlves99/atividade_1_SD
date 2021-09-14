using Cbm.BaseRazor.Helpers;
using Compartilhado.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontEnd.Repository
{
    public class BingoRep : IRepositoryBingo
    {
        private IHttpService _httpService;
        private string baseUrl = @"/api/Cartela";

        public BingoRep(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public int Id { get; set; } = 1;

        public async Task<int> SortearPedra()
        {
            var result = await _httpService.Post<object, int>(baseUrl + @"/sortear", null);
            if (result.Sucess)
                return result.Response;

            return -1;
        }

        public async Task<bool> VericarCartela(Cartela cartela)
        {
            var result = await _httpService.Post<Cartela, bool>(baseUrl + @"/verificar", cartela);
            if (result.Sucess)
                return result.Response;

            return false;
        }

        public async Task<List<int>> GetNumerosSorteados()
        {
            var result = await _httpService.Get<List<int>>(baseUrl + @"/numerosSorteio");
            if (result.Sucess)
                return result.Response;

            return null;
        }
    }
}
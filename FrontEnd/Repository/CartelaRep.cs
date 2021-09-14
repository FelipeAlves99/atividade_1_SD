using Cbm.BaseRazor.Helpers;
using Compartilhado.Models;
using System;
using System.Threading.Tasks;

namespace FrontEnd.Repository
{
    public class CartelaRep : IRepositoryCartela
    {
        private IHttpService _httpService;
        private string baseUrl = @"/api/Bingo";

        public CartelaRep(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<Cartela> GenerateCartela()
        {
            var result = await _httpService.Get<Cartela>(baseUrl + @"/NovaCartela");
            if (result.Sucess)
            {
                return result.Response;
            }

            return null;
        }

        public Usuario ComprarCartela(Usuario user, Cartela cartela)
        {
            throw new NotImplementedException();
        }
    }
}
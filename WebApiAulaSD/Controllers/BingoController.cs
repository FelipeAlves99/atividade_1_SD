using Compartilhado.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApiAulaSD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BingoController : ControllerBase
    {
        private FakeBingoRep _fakeBingoRep;

        public BingoController() : base()
        {
            _fakeBingoRep = new FakeBingoRep();
        }

        [HttpGet("numerosSorteio")]
        public async Task<ActionResult<List<int>>> NumeroSorteados(int idBingo)
        {
            return _fakeBingoRep.GetNumerosSorteados();
        }

        [HttpPost("sortear")]
        public void SortearPedra(int idBingo)
        {
            _fakeBingoRep.SortearPedra();
            return;
        }

        [HttpPost("verificar")]
        public bool VerificarCartela(Cartela cartela)
        {
            var result = _fakeBingoRep.VericarCartela(cartela);
            return result;
        }
    }
}
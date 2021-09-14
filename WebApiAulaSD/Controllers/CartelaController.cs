using Compartilhado.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApiAulaSD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartelaController : ControllerBase
    {
        private FakeCartelaRep _fakeCartelaRep;

        public CartelaController() : base()
        {
            _fakeCartelaRep = new FakeCartelaRep();
        }

        [HttpGet("NovaCartela")]
        public async Task<ActionResult<Cartela>> Get()
        {
            return _fakeCartelaRep.GenerateCartela();
        }
    }
}
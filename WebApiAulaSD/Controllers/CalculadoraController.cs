using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAulaSD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : Controller
    {

        //Exemplo
        //api/[controller]/somar?numA=1&numB=2
        [HttpGet("somar")]
        public async Task<ActionResult<int>> Get(int numA, int numB)
        {
            int resultado = numA + numB;
            return  resultado;
        }
        //Exemplo
        //api/[controller]/quadrado/4
        [HttpGet("quadrado/{i}")]
        public  async Task<ActionResult<int>> Get(int i)
        {
            return i*i;
        }


        [HttpGet("cubo/{i}")]
        public async Task<ActionResult<int>> GetCubo(int i)
        {
            return i * i *i;
        }

    }
}

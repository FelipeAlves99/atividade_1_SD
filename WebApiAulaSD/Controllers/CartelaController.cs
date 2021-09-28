using Compartilhado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAulaSD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartelaController : ControllerBase
    {
        private FakeCartelaRep _fakeCartelaRep;
        private AppDbContext _context;

        public CartelaController(AppDbContext context) : base()
        {
            _fakeCartelaRep = new FakeCartelaRep();
            _context = context;
        }

        [HttpGet("NovaCartela")]
        public async Task<ActionResult<Cartela>> Get()
        {
            return _fakeCartelaRep.GenerateCartela();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cartela>> GetById(int id)
        {
            var result = await _context.Cartelas.FirstOrDefaultAsync(c => c.Id == id);

            if (result is null)
                NotFound("Cartela não encontrada");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Cartela>> Create(Cartela cartela)
        {
            _context.Cartelas.Add(cartela);
            await _context.SaveChangesAsync();
            return Created("Cartela criada", null);
        }

        [HttpPut]
        public async Task<ActionResult<Cartela>> Update(Cartela cartela)
        {
            var result = await _context.Cartelas.AsNoTracking().FirstOrDefaultAsync(c => c.Id == cartela.Id);
            if (result is null)
                return NotFound("Cartela não encontrada");

            _context.Cartelas.Update(cartela);

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Cartela>> Delete(int id)
        {
            var result = await _context.Cartelas.FirstOrDefaultAsync(c => c.Id == id);
            if (result is null)
                return NotFound("Cartela não encontrada");

            _context.Cartelas.Remove(result);

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
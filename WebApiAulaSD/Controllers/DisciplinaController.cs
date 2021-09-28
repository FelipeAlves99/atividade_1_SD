using Compartilhado.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAulaSD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase, IGenericController<Disciplina>
    {
        private AppDbContext _context;

        public DisciplinaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> Create(Disciplina entity)
        {
            _context.Disciplinas.Add(entity);
            await _context.SaveChangesAsync();
            return Created("Cartela criada", null);
        }

        [HttpPut]
        public async Task<ActionResult> Update(Disciplina entity)
        {
            var result = await _context.Disciplinas.AsNoTracking().FirstOrDefaultAsync(d => d.Id == entity.Id);
            if (result is null)
                return NotFound("Disciplina não encontrada");

            _context.Disciplinas.Update(entity);

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(Disciplina entity)
        {
            var result = await _context.Disciplinas.FirstOrDefaultAsync(c => c.Id == entity.Id);
            if (result is null)
                return NotFound("Cartela não encontrada");

            _context.Disciplinas.Remove(result);

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Disciplina>>> GetAll()
        {
            var result = await _context.Disciplinas.ToListAsync();
            return Ok(result.AsEnumerable());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Disciplina>> GetById(string id)
        {
            if (Guid.TryParse(id, out Guid outId))
                BadRequest("Id informado é inválido");

            var result = await _context.Disciplinas.FirstOrDefaultAsync(d => d.Id == outId);

            if (result is null)
                NotFound("Disciplina não encontrada");

            return Ok(result);
        }
    }
}
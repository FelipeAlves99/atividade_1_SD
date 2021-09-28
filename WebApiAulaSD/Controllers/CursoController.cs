using Compartilhado.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApiAulaSD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase, IGenericController<Curso>
    {
        private AppDbContext _context;

        public CursoController(AppDbContext context)
        {
            _context = context;
        }

        public Task<ActionResult> Create(Curso entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> Update(Curso entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> Delete(Curso entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Curso>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Curso>> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
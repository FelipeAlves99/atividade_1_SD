using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Compartilhado.Entities;

namespace WebApiAulaSD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase, IGenericController<Aluno>
    {
        private AppDbContext _context;

        public AlunoController(AppDbContext context)
        {
            _context = context;
        }

        public Task<ActionResult> Create(Aluno entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> Update(Aluno entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> Delete(Aluno entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Aluno>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Aluno>> GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
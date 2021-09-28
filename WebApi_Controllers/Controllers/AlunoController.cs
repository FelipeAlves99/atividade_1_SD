using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi_Controllers.Entities;

namespace WebApi_Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase, IGenericController<Aluno>
    {
        public void Create(Aluno entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Aluno entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Aluno entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Aluno>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Aluno>> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
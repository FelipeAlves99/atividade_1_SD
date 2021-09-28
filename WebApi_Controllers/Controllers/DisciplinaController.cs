using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi_Controllers.Entities;

namespace WebApi_Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase, IGenericController<Disciplina>
    {
        public void Create(Disciplina entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Disciplina entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Disciplina entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Disciplina>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Disciplina>> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
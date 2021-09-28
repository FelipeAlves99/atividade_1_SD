using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Controllers.Entities;

namespace WebApi_Controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase, IGenericController<Curso>
    {
        public void Create(Curso entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Curso entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Curso entity)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<IEnumerable<Curso>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<Curso>> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

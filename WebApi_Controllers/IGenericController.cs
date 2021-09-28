using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi_Controllers.Entities;

namespace WebApi_Controllers
{
    public interface IGenericController<T> where T : Entity
    {
        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);

        Task<ActionResult<IEnumerable<T>>> GetAll();
        
        Task<ActionResult<T>> GetById(int id);
    }
}
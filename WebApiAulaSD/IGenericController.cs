using Compartilhado.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApiAulaSD
{
    public interface IGenericController<T> where T : Entity
    {
        Task<ActionResult> Create(T entity);

        Task<ActionResult> Update(T entity);

        Task<ActionResult> Delete(T entity);

        Task<ActionResult<IEnumerable<T>>> GetAll();
        
        Task<ActionResult<T>> GetById(string id);
    }
}
using System.Threading.Tasks;

namespace Compartilhado.Models
{
    public interface IRepositoryCartela
    {
        Task<Cartela> GenerateCartela();

        Usuario ComprarCartela(Usuario user, Cartela cartela);
    }
}
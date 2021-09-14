using System.Collections.Generic;
using System.Threading.Tasks;

namespace Compartilhado.Models
{
    public interface IRepositoryBingo
    {
        int Id { get; set; }

        Task<List<int>> GetNumerosSorteados();
        Task<bool> VericarCartela(Cartela cartela);
        Task<int> SortearPedra();
    }
}
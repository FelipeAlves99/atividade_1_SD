using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartilhado.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Cartela> MinhasCartelas {get;set;}

    }
}

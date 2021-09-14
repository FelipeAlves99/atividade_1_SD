using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartilhado.Models
{
    public class Cartela
    {
        public int Id { get; set; }
        public bool Ativa { get; set; }
        public List<int> CartelaNumeros { get; set; }
        public List<bool> CartelaMarcacao { get; set; }

        public bool Verificar(int num)
        {
            var retorno = false;

            for (int i=0; i< CartelaNumeros.Count;i++)
            {
                if (CartelaNumeros[i] == num)
                {
                    CartelaMarcacao[i] = true;
                    retorno = true;
                }
            }

            return retorno;
        }
    }
}

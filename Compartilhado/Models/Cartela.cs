using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Compartilhado.Models
{
    public class Cartela
    {
        public int Id { get; set; }
        public bool Ativa { get; set; }
        public string Numeros { get; set; }

        [NotMapped]
        public List<int> CartelaNumeros { get; set; }

        [NotMapped]
        public List<bool> CartelaMarcacao { get; set; }

        public bool Verificar(int num)
        {
            var retorno = false;

            for (int i = 0; i < CartelaNumeros.Count; i++)
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
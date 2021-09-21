using System;
using System.Collections.Generic;

namespace Compartilhado.Models
{
    public class FakeBingoRep
    {
        private List<int> _fakeData;
        private List<int> sorteio;
        private Random random;

        public FakeBingoRep()
        {
            _fakeData = new List<int>
            {
                random.Next(1, 99),
                random.Next(1, 99),
                random.Next(1, 99),
                random.Next(1, 99),
                random.Next(1, 99),
                random.Next(1, 99),
                random.Next(1, 99),
                random.Next(1, 99),
                random.Next(1, 99)
            };

            sorteio = new List<int>();
        }

        public int Id { get; set; } = 1;

        public List<int> GetNumerosSorteados()
        {
            return sorteio;
        }

        public int SortearPedra()
        {
            int retorno = _fakeData[sorteio.Count];
            sorteio.Add(retorno);
            return retorno;
        }

        public bool VericarCartela(Cartela cartela)
        {
            bool retorno = true;
            for (int i = 0; i < cartela.CartelaMarcacao.Count; i++)
            {
                retorno = sorteio.Contains(cartela.CartelaNumeros[i]);
                if (retorno == false)
                    break;
            }

            return retorno;
        }
    }
}
using System.Collections.Generic;

namespace Compartilhado.Models
{
    public class FakeBingoRep
    {
        private List<int> _fakeData = new List<int> { 1, 4, 7, 2, 11, 3, 22, 9, 33 };
        private List<int> sorteio = new List<int>();

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
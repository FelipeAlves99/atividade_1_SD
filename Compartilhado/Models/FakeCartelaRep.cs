using System;
using System.Collections.Generic;

namespace Compartilhado.Models
{
    public class FakeCartelaRep
    {
        private List<Cartela> cartelas;
        private int count = 0;

        public FakeCartelaRep()
        {
            cartelas = new List<Cartela>();
            cartelas.Add(new Cartela
            {
                Ativa = true,
                Id = 1000,
                CartelaNumeros = new List<int> { 1, 2, 3 },
                CartelaMarcacao = new List<bool> { false, false, false }
            });
            cartelas.Add(new Cartela
            {
                Ativa = true,
                Id = 1001,
                CartelaNumeros = new List<int> { 10, 20, 30 },
                CartelaMarcacao = new List<bool> { false, false, false }
            });
            cartelas.Add(new Cartela
            {
                Ativa = true,
                Id = 1002,
                CartelaNumeros = new List<int> { 11, 22, 33 },
                CartelaMarcacao = new List<bool> { false, false, false }
            });
        }

        public Usuario ComprarCartela(Usuario user, Cartela cartela)
        {
            throw new NotImplementedException();
        }

        public Cartela GenerateCartela()
        {
            if (count < 2)
            {
                return cartelas[count];
                count++;
            }
            else
            {
                count = 0;
                return cartelas[count];
                count++;
            }
        }
    }
}
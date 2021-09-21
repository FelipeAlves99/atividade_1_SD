using System;
using System.Collections.Generic;

namespace Compartilhado.Models
{
    public class FakeCartelaRep
    {
        private List<Cartela> cartelas;
        private int count = 0;
        private Random random;

        public FakeCartelaRep()
        {
            cartelas = new List<Cartela>();
            cartelas.Add(new Cartela
            {
                Ativa = true,
                Id = 1000,
                CartelaNumeros = new List<int> { random.Next(1, 99), random.Next(1, 99), random.Next(1, 99) },
                CartelaMarcacao = new List<bool> { false, false, false }
            });
            cartelas.Add(new Cartela
            {
                Ativa = true,
                Id = 1001,
                CartelaNumeros = new List<int> { random.Next(1, 99), random.Next(1, 99), random.Next(1, 99) },
                CartelaMarcacao = new List<bool> { false, false, false }
            });
            cartelas.Add(new Cartela
            {
                Ativa = true,
                Id = 1002,
                CartelaNumeros = new List<int> { random.Next(1, 99), random.Next(1, 99), random.Next(1, 99) },
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
                count++;
                return cartelas[count];
            }
            else
            {
                count = 0;
                count++;
                return cartelas[count];
            }
        }
    }
}
using System.Collections.Generic;

namespace Compartilhado.Entities
{
    public class Curso : Entity
    {
        public Curso(string nome, int semestres, string area)
        {
            Nome = nome;
            Semestres = semestres;
            Area = area;
        }

        public string Nome { get; set; }
        public int Semestres { get; set; }
        public string Area { get; set; }

        public ICollection<Disciplina> Disciplinas { get; set; }
    }
}
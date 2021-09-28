using System;

namespace WebApi_Controllers.Entities
{
    public class Disciplina : Entity
    {
        protected Disciplina()
        { }

        public Disciplina(string nome, int semestre, int horasSemestre, Guid cursoId)
        {
            Nome = nome;
            Semestre = semestre;
            HorasSemestre = horasSemestre;
            CursoId = cursoId;
        }

        public string Nome { get; set; }
        public int Semestre { get; set; }
        public int HorasSemestre { get; set; }
        public Guid CursoId { get; set; }
        public Curso Curso { get; set; }
    }
}
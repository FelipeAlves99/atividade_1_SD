namespace Compartilhado.Entities
{
    public class Aluno : Entity
    {
        public Aluno(string nome, string ra, int idade)
        {
            Nome = nome;
            Ra = ra;
            Idade = idade;
        }

        public string Nome { get; set; }
        public string Ra { get; set; }
        public int Idade { get; set; }
    }
}
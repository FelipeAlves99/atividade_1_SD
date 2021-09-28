using Compartilhado.Entities;
using Compartilhado.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiAulaSD
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Cartela> Cartelas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;


namespace WebAppSenac.Models
{
    public class ContextoEscola : DbContext
    {
        public ContextoEscola(DbContextOptions<ContextoEscola> options) : base(options)
        { 
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("Alunos");
            modelBuilder.Entity<Aluno>().ToTable("Professores");
            modelBuilder.Entity<Aluno>().ToTable("Disciplina");

        }
    }
}

using Microsoft.EntityFrameworkCore;


namespace WebAppSenac.Models
{
    public class ContextoEscola : DbContext
    {
        public ContextoEscola(DbContextOptions<ContextoEscola> options) : base(options)
        { 
        }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("Alunos");
            modelBuilder.Entity<Professor>().ToTable("Professores");
            modelBuilder.Entity<Disciplina>().ToTable("Disciplinas");

        }
    }
}

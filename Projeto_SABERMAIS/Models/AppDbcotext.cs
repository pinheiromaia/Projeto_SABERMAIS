using Microsoft.EntityFrameworkCore;

namespace Projeto_SABERMAIS.Models
{
    public class AppDbcotext : DbContext
    {
        public AppDbcotext(DbContextOptions<AppDbcotext> options) : base(options)
        {
        }
        public DbSet<Pergunta> Perguntas { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
        public DbSet<Aula> Aulas { get; set; }
    }
}

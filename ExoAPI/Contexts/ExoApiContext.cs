using ExoAPI.Domains;
using Microsoft.EntityFrameworkCore;

namespace ExoAPI.Contexts
{
    public class ExoApiContext : DbContext
    {
        public ExoApiContext()
        {
            
        }
        public ExoApiContext(DbContextOptions<ExoApiContext> options) : base(options)
        {   
        }
        // vamos utilizar esse método para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured)
                //cada provedor tem sua sintaxe para especificacao
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-5RGCM6T\\SQLEXPRESS; initial catalog = ExoApi; Integrated Security = True; TrustServerCerficate=True");
        }
        // dbset representa as entidades que serao utilizadas nas operacoes de leitura, criacao, atualizacao e delecao
        public DbSet<Projeto> Projetos { get; set; }
    }
}

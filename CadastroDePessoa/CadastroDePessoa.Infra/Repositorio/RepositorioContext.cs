using System;
using CadastroDePessoa.Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CadastroDePessoa.Infra.Repositorio
{
    
    public class RepositorioContext : DbContext
    {
        public RepositorioContext(DbContextOptions<RepositorioContext> options) : base(options) {

            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            modelBuilder.ApplyConfiguration(new DependenteConfiguration());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

      
    }
}

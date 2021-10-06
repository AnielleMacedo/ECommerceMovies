using ECommerceMovies.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceMovies.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //sobrescrivo o metodo create pra indicar q teemos uma tabela join criada a partir de relacao N a N
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attore_Film>().HasKey(am => new
            {
                am.AttoreId,
                am.FilmId
            });

            modelBuilder.Entity<Attore_Film>().HasOne(m => m.Film).WithMany( am => am.Attori_Films).HasForeignKey(m => m.FilmId);
            modelBuilder.Entity<Attore_Film>().HasOne(m => m.Attore).WithMany(am => am.Attori_Films).HasForeignKey(m => m.AttoreId);


            base.OnModelCreating(modelBuilder);
        }

        //agora vamos efinir o nome das tabelas para cada modelo
        public DbSet<Attore> Attori { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Attore_Film> Attori_Films { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Produttore> Produttori { get; set; }
      


    }
}

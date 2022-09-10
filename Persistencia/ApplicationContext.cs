using System;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace persistencia
{
    public class ApplicationContext: DbContext
    {
        private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=TallerAutos;Integrated Security=True;";
        public DbSet<Persona> Persona {get; set;}

        public DbSet<Auto> Auto {get; set;}


        public ApplicationContext(){}

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        :base(options)
    {
    }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

    }
}

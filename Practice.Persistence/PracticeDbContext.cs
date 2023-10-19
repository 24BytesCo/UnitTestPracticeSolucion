using Microsoft.EntityFrameworkCore;
using Practice.Domain;
using System;

namespace Practice.Persistence
{
    public class PracticeDbContext : DbContext
    {
        public PracticeDbContext(DbContextOptions<PracticeDbContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }

        // DbSet para la entidad Course que se mapeará en la base de datos.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurando el modelo de base de datos.

            modelBuilder.Entity<Course>()
                .Property(e => e.Price)
                .HasPrecision(14, 2);
            // Configuración de precisión para la propiedad Price de la entidad Course.

            modelBuilder.Entity<Course>().HasData(
                // Inserción de datos iniciales.
                new Course
                {
                    CourseId = Guid.NewGuid(),
                    Title = "Mastering Clean Architecture: Robust and Scalable Software Design",
                    Description = "This Clean Architecture course will immerse you in the exciting world of robust and scalable software design. Clean Architecture, also known as 'Clean Architecture,' is a software development methodology that encourages the creation of flexible, maintainable, and high-quality systems.",
                    CreationDate = DateTime.Now,
                    PublicationDate = DateTime.Now.AddMonths(2),
                    Price = 60
                }
            );

            modelBuilder.Entity<Course>().HasData(
                // Inserción de datos iniciales.
                new Course
                {
                    CourseId = Guid.NewGuid(),
                    Title = "Mastering SOLID Principles: Building Robust and Maintainable Software",
                    Description = "This SOLID Principles course will take you deep into the realm of building robust and maintainable software. SOLID is a set of five design principles in object-oriented programming that aim to make software more understandable, flexible, and maintainable.",
                    CreationDate = DateTime.Now,
                    PublicationDate = DateTime.Now.AddMonths(4),
                    Price = 40
                }
            );

            modelBuilder.Entity<Course>().HasData(
                // Inserción de datos iniciales.
                new Course
                {
                    CourseId = Guid.NewGuid(),
                    Title = "Mastering Docker: Container Development and Orchestration",
                    Description = "This Docker course will immerse you in the exciting world of container development and orchestration. Docker is a platform that revolutionizes the way we develop, deploy, and run applications, enabling efficient and scalable management of development and production environments.",
                    CreationDate = DateTime.Now,
                    PublicationDate = DateTime.Now.AddMonths(6),
                    Price = 45
                }
            );

            base.OnModelCreating(modelBuilder);
            // Llamada al método base para completar la configuración del modelo.
        }
    }
}

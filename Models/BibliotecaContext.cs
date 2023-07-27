using Microsoft.EntityFrameworkCore;

namespace BootstrapDashboard.Models;

public class BibliotecaContext : DbContext
{
    public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
    {
    }

    public DbSet<Genero> Genero { get; set; }
    public DbSet<Libro> Libros { get; set; }

    // public DbSet<Lector> Lectores { get; set; }

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        OnBeforeSaving();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    public override async Task<int> SaveChangesAsync(
       bool acceptAllChangesOnSuccess,
       CancellationToken cancellationToken = default(CancellationToken)
    )
    {
        OnBeforeSaving();
        return (await base.SaveChangesAsync(acceptAllChangesOnSuccess,
                      cancellationToken));
    }

    private void OnBeforeSaving()
    {
        var entries = ChangeTracker.Entries();
        var utcNow = DateTime.UtcNow;

        foreach (var entry in entries)
        {
            // for entities that inherit from BaseEntity,
            // set UpdatedOn / CreatedOn appropriately
            if (entry.Entity is BaseEntity trackable)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        // set the updated date to "now"
                        trackable.UpdatedAt = utcNow;

                        // mark property as "don't touch"
                        // we don't want to update on a Modify operation
                        entry.Property("CreatedAt").IsModified = false;
                        break;

                    case EntityState.Added:
                        // set both updated and created date to "now"
                        trackable.CreatedAt = utcNow;
                        trackable.UpdatedAt = utcNow;
                        break;
                }
            }
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Guid generoPoliciaco = Guid.NewGuid();
        DateTime c = DateTime.UtcNow;
        DateTime u = DateTime.UtcNow;
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Genero>().HasData(
        new Genero
        {
            CategoryId = 1,
            Nombre = "Novela Policiaca",
            CreatedAt = c,
            UpdatedAt = u
        },
        new Genero
        {
            CategoryId = 2,
            Nombre = "Romántico",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 3,
            Nombre = "Erótico",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 4,
            Nombre = "Ficción",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 5,
            Nombre = "Biografía",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 6,
            Nombre = "Ensayo",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 7,
            Nombre = "Poesía",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        }
    );
        //https://www.todostuslibros.com/autor/daniel-chavarria
        modelBuilder.Entity<Libro>().HasData(
            new Libro
            {
                IdBook = 1,
                Nombre = "Una pica en Flandes",
                CategoryId = 1,
                ISBN = "978-84-8136-542-9",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                IdBook = 2,
                Nombre = "Allá ellos",
                CategoryId = 1,
                ISBN = "978-84-15313-05-2",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                IdBook = 3,
                Nombre = "Adiós muchachos",
                CategoryId = 1,
                ISBN = "978-84-15313-59-5",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                IdBook = 4,
                Nombre = "Juguete nuevo",
                CategoryId = 1,
                ISBN = "978-84-7884-546-0",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                IdBook = 5,
                Nombre = "Raúl Sendic",
                CategoryId = 1,
                ISBN = "978-84-16350-14-8",
                Estado = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                IdBook = 6,
                Nombre = "Aquel año en Madrid",
                CategoryId = 1,
                ISBN = "978-84-7884-500-2",
                Estado = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                IdBook = 7,
                Nombre = "El último room service",
                CategoryId = 1,
                ISBN = "978-956-366-003-6",
                Estado = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                IdBook = 8,
                Nombre = "Príapos",
                CategoryId = 1,
                ISBN = "978-84-8136-572-6",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                IdBook = 9,
                Nombre = "LO QUE DURA DURA",
                CategoryId = 1,
                ISBN = "978-84-96546-19-6",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                IdBook = 10,
                Nombre = "De la Habana ha llegado",
                CategoryId = 1,
                ISBN = "978-84-7884-370-1",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                IdBook = 11,
                Nombre = "El aguacate y la virtud",
                CategoryId = 1,
                ISBN = "978-959-218-103-8",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        )
        ;
        // modelBuilder.Entity<Course>().ToTable("Course");
        // modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
        // modelBuilder.Entity<Student>().ToTable("Student");
    }
}
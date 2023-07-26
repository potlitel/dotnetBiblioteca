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
                        entry.Property("CreatedOn").IsModified = false;
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
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Genero>().HasData(
        new Genero
        {
            Id = generoPoliciaco,
            Nombre = "Novela Policiaca",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            Id = Guid.NewGuid(),
            Nombre = "Romántico",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            Id = Guid.NewGuid(),
            Nombre = "Erótico",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            Id = Guid.NewGuid(),
            Nombre = "Ficción",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            Id = Guid.NewGuid(),
            Nombre = "Biografía",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            Id = Guid.NewGuid(),
            Nombre = "Ensayo",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            Id = Guid.NewGuid(),
            Nombre = "Poesía",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        }
    );
        //https://www.todostuslibros.com/autor/daniel-chavarria
        modelBuilder.Entity<Libro>().HasData(
            new Libro
            {
                Id = Guid.NewGuid(),
                Nombre = "Una pica en Flandes",
                GeneroId = generoPoliciaco,
                ISBN = "978-84-8136-542-9",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                Id = Guid.NewGuid(),
                Nombre = "Allá ellos",
                GeneroId = generoPoliciaco,
                ISBN = "978-84-15313-05-2",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                Id = Guid.NewGuid(),
                Nombre = "Adiós muchachos",
                GeneroId = generoPoliciaco,
                ISBN = "978-84-15313-59-5",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                Id = Guid.NewGuid(),
                Nombre = "Juguete nuevo",
                GeneroId = generoPoliciaco,
                ISBN = "978-84-7884-546-0",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                Id = Guid.NewGuid(),
                Nombre = "Raúl Sendic",
                GeneroId = generoPoliciaco,
                ISBN = "978-84-16350-14-8",
                Estado = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                Id = Guid.NewGuid(),
                Nombre = "Aquel año en Madrid",
                GeneroId = generoPoliciaco,
                ISBN = "978-84-7884-500-2",
                Estado = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                Id = Guid.NewGuid(),
                Nombre = "El último room service",
                GeneroId = generoPoliciaco,
                ISBN = "978-956-366-003-6",
                Estado = true,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                Id = Guid.NewGuid(),
                Nombre = "Príapos",
                GeneroId = generoPoliciaco,
                ISBN = "978-84-8136-572-6",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                Id = Guid.NewGuid(),
                Nombre = "LO QUE DURA DURA",
                GeneroId = generoPoliciaco,
                ISBN = "978-84-96546-19-6",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                Id = Guid.NewGuid(),
                Nombre = "De la Habana ha llegado",
                GeneroId = generoPoliciaco,
                ISBN = "978-84-7884-370-1",
                Estado = false,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Libro
            {
                Id = Guid.NewGuid(),
                Nombre = "El aguacate y la virtud",
                GeneroId = generoPoliciaco,
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
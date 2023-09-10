using Microsoft.EntityFrameworkCore;

namespace BootstrapDashboard.Models;

public class BibliotecaContext : DbContext
{
    public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
    {
    }

    public DbSet<Genero> Genero { get; set; }
    public DbSet<Libro> Libros { get; set; }
    public DbSet<Lector> Lectores { get; set; }

    public DbSet<Prestamo> Prestamos { get; set; }

    // public DbSet<Lector> Lectores { get; set; }

    /**
     * Description: SaveChanges method
     * @param {any} boolacceptAllChangesOnSuccess
     * @returns {any}
        */
    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        OnBeforeSaving();
        return base.SaveChanges(acceptAllChangesOnSuccess);
    }

    /**
     * Description: SaveChangesAsync method
     * @param {any} boolacceptAllChangesOnSuccess
     * @param {any} CancellationTokencancellationToken=default(CancellationToken
     * @returns {any}
        */
    public override async Task<int> SaveChangesAsync(
       bool acceptAllChangesOnSuccess,
       CancellationToken cancellationToken = default(CancellationToken)
    )
    {
        OnBeforeSaving();
        return (await base.SaveChangesAsync(acceptAllChangesOnSuccess,
                      cancellationToken));
    }

    /**
     * Description: OnBeforeSaving method
     * @returns {any}
        */
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

    /**
     * Description: OnModelCreating method
     * @param {any} ModelBuildermodelBuilder
     * @returns {any}
        */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Guid generoPoliciaco = Guid.NewGuid();
        DateTime c = DateTime.UtcNow;
        DateTime u = DateTime.UtcNow;
        base.OnModelCreating(modelBuilder);
        //Establecemos el campo 'ISBN' como único en todo el sistema
        modelBuilder.Entity<Libro>()
        .HasIndex(u => u.ISBN)
        .IsUnique();
        //Establecemos para la entidad Préstamo, que los campos LibroId y LectorId sean únicos en todo el sistema
        modelBuilder.Entity<Prestamo>()
            .HasIndex(p => new { p.LibroId, p.LectorId }).IsUnique();

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
        },
        new Genero
        {
            CategoryId = 8,
            Nombre = "Clásicos Literarios",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 9,
            Nombre = "Cómic y Libros Ilustrados",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 10,
            Nombre = "Cuentos y Relatos",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 11,
            Nombre = "Fantasía",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 12,
            Nombre = "Humor",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 13,
            Nombre = "Infantil",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 14,
            Nombre = "Juvenil",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 15,
            Nombre = "Novela Histórica",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 16,
            Nombre = "Novela Negra y Policiaca",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 17,
            Nombre = "Novela Romántica",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 18,
            Nombre = "Terror y Thriller",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 19,
            Nombre = "Arte",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 20,
            Nombre = "Autoayuda",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 21,
            Nombre = "Biografías y Autobiografías",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 22,
            Nombre = "Cocina y Gastronomía",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 23,
            Nombre = "Deportes",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 24,
            Nombre = "Divulgación Científica",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 25,
            Nombre = "Enciclopedias y Diccionarios",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 26,
            Nombre = "Filosofía",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 27,
            Nombre = "Historia",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 28,
            Nombre = "Idiomas",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 29,
            Nombre = "Libros de Texto",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 30,
            Nombre = "Libros Técnicos",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 31,
            Nombre = "Madres y Padres",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 32,
            Nombre = "Negocios e Inversiones",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 33,
            Nombre = "Religión",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 34,
            Nombre = "Viajes",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 35,
            Nombre = "Teatro y Dramático",
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        },
        new Genero
        {
            CategoryId = 36,
            Nombre = "Lírico",
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
        );

        modelBuilder.Entity<Lector>().HasData(
            new Lector
            {
                IdLector = 1,
                Nombre = "Anaías",
                Apellidos = "Casanova Almanza",
                Email = "AnaiasCasanovaAlmanza@jourrapide.com",
                Direccion = "Ourense, 25 43141 Vilallonga del Camp",
                Telefono = "783 962 738",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 2,
                Nombre = "Pericles",
                Apellidos = "Castro Montoya",
                Email = "PericlesCastroMontoya@armyspy.com",
                Direccion = "Plaza Colón, 55 26100 Torrecilla en Cameros",
                Telefono = "783 962 730",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 3,
                Nombre = "Carpo",
                Apellidos = "Ontiveros Miranda",
                Email = "CarpoOntiverosMiranda@dayrep.com",
                Direccion = "Calvo Sotelo, 31 47230 Matapozuelos",
                Telefono = "783 962 588",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 4,
                Nombre = "Monserrat ",
                Apellidos = "Covarrubias Quiñones",
                Email = "MonserratCovarrubiasQuinones@jourrapide.com",
                Direccion = "Cruce Casa de Postas, 3 18420 Lanjarón",
                Telefono = "734 910 062",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 5,
                Nombre = "Omaro",
                Apellidos = "Gallardo Suárez",
                Email = "OmaroGallardoSuarez@dayrep.com",
                Direccion = "Camiño Ancho, 43 37765 Monleón",
                Telefono = "748 412 755",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 6,
                Nombre = "Saúl",
                Apellidos = "Olivares Escobar",
                Email = "SaulOlivaresEscobar@jourrapide.com",
                Direccion = "C/ Hijuela de Lojo, 30 20493 Berrobi",
                Telefono = "662 479 434",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 7,
                Nombre = "Tulia",
                Apellidos = "Barela Méndez",
                Email = "TuliaBarelaMendez@rhyta.com",
                Direccion = "Bouciña, 25 43780 Gandesa",
                Telefono = "681 035 582",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 8,
                Nombre = "Natividad",
                Apellidos = "Henríquez Pichardo",
                Email = "NatividadHenriquezPichardo@teleworm.us",
                Direccion = "C/ Domingo Beltrán, 54 02250 Abengibre",
                Telefono = "664 470 154",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 9,
                Nombre = "Nabor",
                Apellidos = "Alvarado González",
                Email = "NaborAlvaradoGonzalez@dayrep.com",
                Direccion = "C/ Señores Curas, 11 12161 la Torre d'En Besora",
                Telefono = "633 722 764",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 10,
                Nombre = "Eleodoro",
                Apellidos = "Solórzano Maya",
                Email = "EleodoroSolorzanoMaya@jourrapide.com",
                Direccion = "Rúa Olmos, 5 37330 Babilafuente",
                Telefono = "627 022 447",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 11,
                Nombre = "Yrko",
                Apellidos = "Toro Robles",
                Email = "YrkoToroRobles@dayrep.com",
                Direccion = "El Roqueo, 28 17230 Palamós",
                Telefono = "775 984 852",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 12,
                Nombre = "Evelien",
                Apellidos = "Corral Lara",
                Email = "EvelienCorralLara@armyspy.com",
                Direccion = "Padre Caro, 6 13760 Almuradiel",
                Telefono = "616 556 997",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 13,
                Nombre = "Fulgencio",
                Apellidos = "Ontiveros Vigil",
                Email = "FulgencioOntiverosVigil@teleworm.us",
                Direccion = "Escuadro, 57 46841 Castelló de Rugat",
                Telefono = "669 306 461",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 14,
                Nombre = "Ferdinand",
                Apellidos = "Espinosa Ledesma",
                Email = "FerdinandEspinosaLedesma@teleworm.us",
                Direccion = "Paseo del Atlántico, 76 17500 Ripoll",
                Telefono = "651 089 265",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 15,
                Nombre = "Luperco",
                Apellidos = "Barrientos Sedillo",
                Email = "LupercoBarrientosSedillo@rhyta.com",
                Direccion = "Atamaria, 39 36636 Ribadumia",
                Telefono = "775 279 438",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 16,
                Nombre = "Helda",
                Apellidos = "Hernádez Villegas",
                Email = "HeldaHernadezVillegas@rhyta.com",
                Direccion = "Constitución, 65 37111 Palacios del Arzobispo",
                Telefono = "633 662 355",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 17,
                Nombre = "Elía",
                Apellidos = "Arreola Olivares",
                Email = "EliaArreolaOlivares@armyspy.com",
                Direccion = "C/ Los Herrán, 81 06810 Calamonte",
                Telefono = "612 597 999",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 18,
                Nombre = "Eneas",
                Apellidos = "Vázquez Baca",
                Email = "EneasVazquezBaca@dayrep.com",
                Direccion = "Cañadilla, 89 22300 Barbastro",
                Telefono = "759 793 434",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 19,
                Nombre = "Abbi",
                Apellidos = "Rascón Angulo",
                Email = "AbbiRasconAngulo@jourrapide.com",
                Direccion = "C/ Benito Guinea, 92 08330 Premià de Mar",
                Telefono = "674 325 474",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 20,
                Nombre = "Orieta",
                Apellidos = "Rivas Espinosa",
                Email = "OrietaRivasEspinosa@jourrapide.com",
                Direccion = "Lamas Carbajal, 17 41566 Pedrera",
                Telefono = "766 258 264",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 21,
                Nombre = "Marisel",
                Apellidos = "Banda Alicea",
                Email = "MariselBandaAlicea@dayrep.com",
                Direccion = "Camiño Real, 65 48480 Zaratamo",
                Telefono = "781 296 585",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 22,
                Nombre = "Prudenciano",
                Apellidos = "Zamudio Adame",
                Email = "PrudencianoZamudioAdame@dayrep.com",
                Direccion = "Cruce Casa de Postas, 22 18430 Torvizcón",
                Telefono = "722 720 072",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 23,
                Nombre = "Amalio",
                Apellidos = "Vasquez Solano",
                Email = "AmalioVasquezSolano@dayrep.com",
                Direccion = "Atamaria, 2 36780 A Guarda",
                Telefono = "722 801 512",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 24,
                Nombre = "Zahir",
                Apellidos = "Valverde Elizondo",
                Email = "ZahirValverdeElizondo@armyspy.com",
                Direccion = "Rúa de San Pedro, 79 37795 Berrocal de Salvatierra",
                Telefono = "606 229 390",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            },
            new Lector
            {
                IdLector = 25,
                Nombre = "Liberto",
                Apellidos = "Saldana Pulido",
                Email = "LibertoSaldanaPulido@teleworm.us",
                Direccion = "Carretera del Muelle, 67 12318 Portell de Morella",
                Telefono = "651 019 733",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            }
        );
        modelBuilder.Entity<Prestamo>().HasData(
            new Prestamo
            {
                Id = 1,
                LectorId = 23,
                LibroId = 5,
            },
            new Prestamo
            {
                Id = 2,
                LectorId = 19,
                LibroId = 6,
            }, new Prestamo
            {
                Id = 3,
                LectorId = 7,
                LibroId = 7,
            }
        );
        // modelBuilder.Entity<Course>().ToTable("Course");
        // modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
        // modelBuilder.Entity<Student>().ToTable("Student");
    }
}
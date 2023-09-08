using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootstrapDashboard.Models;

[Table("prestamos")]
public class Prestamo : BaseEntity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key, Column(Order = 0)]
    public int Id { get; set; }
    [Required(ErrorMessage = "Identificador de libro es requerido")]
    public int IdLibro { get; set; }
    public Libro Libro { get; set; } = default!;

    [Required(ErrorMessage = "Identificador de lector es requerido")]
    public int IdLector { get; set; }

    public Lector Lector { get; set; } = default!;
}
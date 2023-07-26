using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootstrapDashboard.Models;

[Table("libros")]
public class Libro : BaseEntity
{
    [Column("LibroId")]
    public Guid Id { get; set; }
    [Required(ErrorMessage = "Nombre de libro es requerido")]
    public string Nombre { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "Por favor seleccione un género.")]
    [Display(Name = "Género")]
    // Foreign key to customer
    [ForeignKey("Genero")]
    public Guid GeneroId { get; set; }
    public virtual Genero Genero { get; set; }
    [Required(ErrorMessage = "ISBN es requerido")]
    [MaxLength(20, ErrorMessage = "El ISBN de un libro no puede exceder los {0} caracteres")]
    [MinLength(10, ErrorMessage = "El ISBN de un libro debe tener al menos {0} caracteres")]
    public string ISBN { get; set; }
    [DefaultValue("false")]
    [Display(Name = "Prestado")]
    public bool Estado { get; set; }
    [NotMapped]
    public string GeneroNombre
    {
        get
        {
            return Genero == null ? "" : Genero.Nombre;
        }
    }

}

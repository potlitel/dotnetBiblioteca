using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BootstrapDashboard.Models;

[Table("generos")]
public class Genero : BaseEntity
{
    // [Key]
    // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    // public int Id { get; set; }
    // [Column("GeneroId")]
    // public int IdGenero { get; set; }
    [Key]
    public int CategoryId { get; set; }
    [Required(ErrorMessage = "Nombre de género es requerido")]
    // [StringLength(50)]
    [MaxLength(50, ErrorMessage = "El nombre del género no puede exceder los {0} caracteres")]
    [MinLength(4, ErrorMessage = "El nombre del género debe tener al menos {0} caracteres")]
    // [Display(Name = "Género")]
    public string Nombre { get; set; }
}

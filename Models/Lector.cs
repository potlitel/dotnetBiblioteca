using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapDashboard.Models;

[Table("lector")]
public class Lector : BaseEntity
{
    [Key]
    public int IdLector { get; set; }

    [Required(ErrorMessage = "Nombre de lector es requerido")]
    public string Nombre { get; set; } = default!;

    [Required(ErrorMessage = "Apellidos de lector es requerido")]
    public string Apellidos { get; set; } = default!;

    [Required(ErrorMessage = "Email de lector es requerido")]
    [EmailAddress(ErrorMessage = "Email inválido")]
    [Remote(action: "IsEmailInUse", controller: "Home")]
    public string Email { get; set; } = default!;

    [NotMapped]
    public string NombreCompleto
    {
        get
        {
            return Nombre + Apellidos;
        }
    }

    [Required(ErrorMessage = "Dirección particular requerida")]
    public string Direccion { get; set; } = default!;

    [Required(ErrorMessage = "Teléfono requerido")]
    [DataType(DataType.PhoneNumber)]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$",
                   ErrorMessage = "Entered phone format is not valid.")]
    public string Telefono { get; set; } = default!;
}
using System.ComponentModel.DataAnnotations;

namespace UGKUM.Innovation.Models.ViewModels;

/// <summary>
/// Modelo del formulario de contacto.
/// Preparado para persistencia futura en SQL Server vía IContactService.
/// </summary>
public class ContactFormViewModel
{
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100, ErrorMessage = "El nombre no puede exceder 100 caracteres.")]
    [Display(Name = "Nombre")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido.")]
    [Display(Name = "Correo")]
    public string Email { get; set; } = string.Empty;

    [Phone(ErrorMessage = "Ingrese un teléfono válido.")]
    [Display(Name = "Teléfono")]
    public string? Phone { get; set; }

    [Required(ErrorMessage = "El mensaje es obligatorio.")]
    [StringLength(2000, MinimumLength = 10, ErrorMessage = "El mensaje debe tener entre 10 y 2000 caracteres.")]
    [Display(Name = "Mensaje")]
    public string Message { get; set; } = string.Empty;
}

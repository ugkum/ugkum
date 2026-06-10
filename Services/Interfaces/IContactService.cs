using UGKUM.Innovation.Models.ViewModels;

namespace UGKUM.Innovation.Services.Interfaces;

/// <summary>
/// Contrato del servicio de contacto.
/// Implementación actual en memoria; reemplazar por repositorio EF Core + SQL Server.
/// </summary>
public interface IContactService
{
    Task<bool> SendMessageAsync(ContactFormViewModel model, CancellationToken cancellationToken = default);
}

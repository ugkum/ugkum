using UGKUM.Innovation.Models.Entities;
using UGKUM.Innovation.Models.ViewModels;
using UGKUM.Innovation.Services.Interfaces;

namespace UGKUM.Innovation.Services;

/// <summary>
/// Implementación temporal del servicio de contacto.
/// Al conectar SQL Server: inyectar ApplicationDbContext y persistir ContactMessage.
/// </summary>
public class ContactService : IContactService
{
    private readonly ILogger<ContactService> _logger;

    // Almacenamiento en memoria para demostración hasta conectar SQL Server
    private static readonly List<ContactMessage> Messages = [];

    public ContactService(ILogger<ContactService> logger)
    {
        _logger = logger;
    }

    public Task<bool> SendMessageAsync(ContactFormViewModel model, CancellationToken cancellationToken = default)
    {
        var entity = new ContactMessage
        {
            Name = model.Name,
            Email = model.Email,
            Phone = model.Phone,
            Message = model.Message,
            CreatedAt = DateTime.UtcNow
        };

        Messages.Add(entity);

        _logger.LogInformation(
            "Mensaje de contacto recibido de {Name} ({Email})",
            entity.Name,
            entity.Email);

        return Task.FromResult(true);
    }
}

namespace UGKUM.Innovation.Models.ViewModels;

/// <summary>
/// ViewModel principal de la landing page.
/// Centraliza el contenido para facilitar futuras migraciones a base de datos o CMS.
/// </summary>
public class LandingPageViewModel
{
    public AboutSection About { get; set; } = new();
    public List<ServiceItem> Services { get; set; } = [];
    public List<ProjectItem> Projects { get; set; } = [];
    public List<TechnologyItem> Technologies { get; set; } = [];
    public List<AdvantageItem> Advantages { get; set; } = [];
}

public class AboutSection
{
    public string Mission { get; set; } = string.Empty;
    public string Vision { get; set; } = string.Empty;
    public List<string> Values { get; set; } = [];
}

public class ServiceItem
{
    public string Icon { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

public class ProjectItem
{
    public string Icon { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Tag { get; set; } = string.Empty;
}

public class TechnologyItem
{
    public string Icon { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}

public class AdvantageItem
{
    public string Icon { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}

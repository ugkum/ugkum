using UGKUM.Innovation.Models.ViewModels;

namespace UGKUM.Innovation.Services;

/// <summary>
/// Provee el contenido estático de la landing page.
/// Futuro: reemplazar por repositorio o CMS.
/// </summary>
public static class LandingContentService
{
    public static LandingPageViewModel GetLandingContent() => new()
    {
        About = new AboutSection
        {
            Mission = "Desarrollar soluciones digitales de alto impacto que transformen la operación de organizaciones en salud y sector empresarial, aplicando las mejores prácticas de la plataforma Microsoft.",
            Vision = "Ser referente en innovación tecnológica en Latinoamérica, reconocidos por la calidad, seguridad y escalabilidad de nuestras soluciones empresariales.",
            Values =
            [
                "Excelencia técnica",
                "Innovación continua",
                "Compromiso con el cliente",
                "Seguridad y confiabilidad",
                "Trabajo colaborativo"
            ]
        },
        Services =
        [
            new ServiceItem
            {
                Icon = "fa-code",
                Title = "Desarrollo Web .NET",
                Description = "Aplicaciones web empresariales con ASP.NET Core, arquitectura limpia y alto rendimiento."
            },
            new ServiceItem
            {
                Icon = "fa-heart-pulse",
                Title = "Sistemas para Salud",
                Description = "Plataformas clínicas, seguimiento de pacientes, indicadores y reportes especializados."
            },
            new ServiceItem
            {
                Icon = "fa-database",
                Title = "SQL Server",
                Description = "Diseño, optimización y administración de bases de datos empresariales robustas."
            },
            new ServiceItem
            {
                Icon = "fa-chart-line",
                Title = "Power BI",
                Description = "Dashboards ejecutivos e inteligencia de negocios para decisiones estratégicas."
            },
            new ServiceItem
            {
                Icon = "fa-gears",
                Title = "Automatización de Procesos",
                Description = "Digitalización y automatización de flujos operativos y administrativos."
            },
            new ServiceItem
            {
                Icon = "fa-lightbulb",
                Title = "Consultoría Tecnológica",
                Description = "Asesoría en transformación digital, arquitectura cloud y modernización de sistemas."
            }
        ],
        Projects =
        [
            new ProjectItem
            {
                Icon = "fa-baby",
                Title = "Sistema Materno Gestante",
                Description = "Sistema para seguimiento y control de gestantes, controles prenatales, indicadores y reportes.",
                Tag = "Salud"
            },
            new ProjectItem
            {
                Icon = "fa-child",
                Title = "Sistema Padrón CRED",
                Description = "Sistema para seguimiento de niños, crecimiento y desarrollo, alertas e indicadores.",
                Tag = "Salud"
            },
            new ProjectItem
            {
                Icon = "fa-chart-pie",
                Title = "Dashboard Ejecutivo",
                Description = "Visualización estratégica de indicadores con Power BI.",
                Tag = "Business Intelligence"
            },
            new ProjectItem
            {
                Icon = "fa-building",
                Title = "Sistema de Gestión Empresarial",
                Description = "Gestión de procesos administrativos y operativos.",
                Tag = "Enterprise"
            }
        ],
        Technologies =
        [
            new TechnologyItem { Icon = "fa-hashtag", Name = "C#" },
            new TechnologyItem { Icon = "fa-microsoft", Name = ".NET" },
            new TechnologyItem { Icon = "fa-globe", Name = "ASP.NET Core" },
            new TechnologyItem { Icon = "fa-database", Name = "SQL Server" },
            new TechnologyItem { Icon = "fa-layer-group", Name = "Entity Framework" },
            new TechnologyItem { Icon = "fa-chart-bar", Name = "Power BI" },
            new TechnologyItem { Icon = "fa-cloud", Name = "Azure" },
            new TechnologyItem { Icon = "fa-github", Name = "GitHub" }
        ],
        Advantages =
        [
            new AdvantageItem
            {
                Icon = "fa-shield-halved",
                Title = "Seguridad",
                Description = "Implementamos las mejores prácticas de seguridad, autenticación y protección de datos."
            },
            new AdvantageItem
            {
                Icon = "fa-arrows-up-down-left-right",
                Title = "Escalabilidad",
                Description = "Arquitecturas diseñadas para crecer con su organización sin comprometer el rendimiento."
            },
            new AdvantageItem
            {
                Icon = "fa-rocket",
                Title = "Innovación",
                Description = "Adoptamos tecnologías de vanguardia para mantener a su empresa a la delantera."
            },
            new AdvantageItem
            {
                Icon = "fa-headset",
                Title = "Soporte",
                Description = "Acompañamiento continuo, mantenimiento y evolución de sus sistemas críticos."
            }
        ]
    };
}

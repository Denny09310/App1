using BlazorBindings.Maui;
using System.Reflection;

namespace App1;

internal partial class App(IServiceProvider services) : BlazorBindingsApplication<AppShell>(services)
{
    protected override void Configure()
    {
        var resources = typeof(App).Assembly.GetCustomAttributes<XamlResourceIdAttribute>()
            .Where(IsDefaultResource)
            .Select(attribute => Activator.CreateInstance(attribute.Type))
            .OfType<ResourceDictionary>();

        foreach (var resource in resources)
        {
            Resources.Add(resource);
        }
    }

    private static bool IsDefaultResource(XamlResourceIdAttribute attribute)
    {
        // Handle differences between windows and other platforms (Eg. Android, IOS, etc.)
        var directory = Path.GetDirectoryName(attribute.Path)?.Replace("\\", "/");
        var extension = Path.GetExtension(attribute.Path);

        return directory == "Resources/Styles" && extension == ".xaml";
    }
}
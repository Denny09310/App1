using BlazorBindings.Maui;
using MauiIcons.Core;
using MauiIcons.Core.Base;
using System.Reflection;

namespace App1;

internal partial class App(IServiceProvider services) : BlazorBindingsApplication<AppShell>(services)
{
    protected override void Configure()
    {
        ConfigureAttachedProperties();
        InitializeResources();
    }

#pragma warning disable MBB001 // Type viene usato solo a scopo di valutazione e potrebbe essere modificato o rimosso in aggiornamenti futuri. Elimina questa diagnostica per continuare.

    private static void ConfigureAttachedProperties()
    {
        AttachedPropertyRegistry.RegisterAttachedPropertyHandler("Icon.Value",
            (sender, e) => MauiIcon.SetValue(sender, (BaseIcon)e));
    }

#pragma warning restore MBB001 // Type viene usato solo a scopo di valutazione e potrebbe essere modificato o rimosso in aggiornamenti futuri. Elimina questa diagnostica per continuare.

    private static bool IsDefaultResource(XamlResourceIdAttribute attribute)
    {
        // Handle differences between windows and other platforms (Eg. Android, IOS, etc.)
        var directory = Path.GetDirectoryName(attribute.Path)?.Replace("\\", "/");
        var extension = Path.GetExtension(attribute.Path);

        return directory == "Resources/Styles" && extension == ".xaml";
    }

    private void InitializeResources()
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
}
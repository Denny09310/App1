using MauiIcons.Core.Base;
using MauiIcons.Material;
using MC = Microsoft.Maui.Controls;

namespace BlazorBindings.Maui.Elements;

public partial class MoreOptionsBottomSheet
{
    private static readonly BaseIcon FavouritesIcon = new()
    {
        Icon = MaterialIcons.Favorite,
    };

    private static readonly BaseIcon HideSourceIcon = new()
    {
        Icon = MaterialIcons.HideSource,
    };

    private static readonly BaseIcon InfoOutlineIcon = new()
    {
        Icon = MaterialIcons.InfoOutline,
    };

    private static readonly BaseIcon PersonRemoveIcon = new()
    {
        Icon = MaterialIcons.PersonRemove,
    };

    private static readonly BaseIcon ReportIcon = new()
    {
        Icon = MaterialIcons.Report,
    };

    private static readonly ResourceDictionary Resources = new()
    {
        new Style(typeof(MC.Button))
        {
            Setters =
            {
                new Setter { Property = MC.View.HorizontalOptionsProperty, Value = LayoutOptions.Start },
                new Setter { Property = MC.VisualElement.BackgroundColorProperty, Value = Colors.Transparent },
                new Setter { Property = MC.Button.TextColorProperty, Value = Colors.Black },
            }
        }
    };
}
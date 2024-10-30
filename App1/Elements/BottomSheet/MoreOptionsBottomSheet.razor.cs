using App1.Extensions;
using MauiIcons.Core.Base;
using MauiIcons.Material;

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

    private static readonly ResourceDictionary Resources = [];

    static MoreOptionsBottomSheet()
    {
        Resources.Scoped("Elements/BottomSheet/MoreOptionsBottomSheet.razor.xaml");
    }
}
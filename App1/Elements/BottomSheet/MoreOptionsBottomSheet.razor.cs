using MauiIcons.Material;
using MCB = MauiIcons.Core.Base;

namespace BlazorBindings.Maui.Elements;

public partial class MoreOptionsBottomSheet
{
    private static readonly MCB.BaseIcon FavouritesIcon = new()
    {
        Icon = MaterialIcons.Favorite,
        IconColor = Colors.Black,
    };

    private static readonly MCB.BaseIcon PersonRemoveIcon = new()
    {
        Icon = MaterialIcons.PersonRemove,
        IconColor = Colors.Black,
    };

    private static readonly MCB.BaseIcon HideSourceIcon = new()
    {
        Icon = MaterialIcons.HideSource,
        IconColor = Colors.Black,
    };

    private static readonly MCB.BaseIcon InfoOutlineIcon = new()
    {
        Icon = MaterialIcons.InfoOutline,
        IconColor = Colors.Black,
    };

    private static readonly MCB.BaseIcon ReportIcon = new()
    {
        Icon = MaterialIcons.Report,
        IconColor = Colors.Red,
    };
}

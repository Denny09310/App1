namespace App1;

public partial class AppShell
{
    public static ImageSource Home => (ImageSource)Application.Current!.Resources["HomeIcon"];
    public static ImageSource Profile => (ImageSource)Application.Current!.Resources["ProfileIcon"];
}
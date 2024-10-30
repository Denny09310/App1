using BlazorBindings.Maui.ComponentGenerator;

// Icons
[assembly: GenerateComponentsFromAssembly(typeof(MauiIcons.Core.MauiIcon))]

// Bottom Sheet
[assembly: GenerateComponent(typeof(The49.Maui.BottomSheet.BottomSheet),
    Exclude = ["Controller"])]

[assembly: GenerateComponent(typeof(The49.Maui.BottomSheet.Detent))]
[assembly: GenerateComponent(typeof(The49.Maui.BottomSheet.MediumDetent))]
[assembly: GenerateComponent(typeof(The49.Maui.BottomSheet.RatioDetent))]
[assembly: GenerateComponent(typeof(The49.Maui.BottomSheet.HeightDetent))]
[assembly: GenerateComponent(typeof(The49.Maui.BottomSheet.FullscreenDetent))]
[assembly: GenerateComponent(typeof(The49.Maui.BottomSheet.AnchorDetent))]
[assembly: GenerateComponent(typeof(The49.Maui.BottomSheet.ContentDetent))]
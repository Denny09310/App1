using Microsoft.AspNetCore.Components;
using TMB = The49.Maui.BottomSheet;

namespace BlazorBindings.Maui.Elements;

public static class AppBottomSheetExtensions
{
    public static Task<TMB.BottomSheet> CreateBottomSheetAsync<TComponent>(this INavigation navigation, Dictionary<string, object>? parameters = null) where TComponent : IComponent
    {
        var body = new RenderFragment(builder =>
        {
            int i = 0;
            builder.OpenComponent<TComponent>(i++);
            if (parameters != null)
            {
                foreach (var (key, value) in parameters)
                {
                    builder.AddComponentParameter(i++, key, value);
                }
            }
            builder.CloseComponent();
        });

#pragma warning disable MBB001 // Type viene usato solo a scopo di valutazione e potrebbe essere modificato o rimosso in aggiornamenti futuri. Elimina questa diagnostica per continuare.

        return ((Navigation)navigation).BuildElement<TMB.BottomSheet>(typeof(AppBottomSheet), new Dictionary<string, object>
        {
            [nameof(AppBottomSheet.Body)] = body,
        });

#pragma warning restore MBB001 // Type viene usato solo a scopo di valutazione e potrebbe essere modificato o rimosso in aggiornamenti futuri. Elimina questa diagnostica per continuare.
    }
}
using BlazorBindings.Maui.Elements.The49.BottomSheet;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using TMB = The49.Maui.BottomSheet;

#pragma warning disable MBB001

namespace BlazorBindings.Maui.Elements;

/// <summary>
/// Extension methods for creating and configuring a BottomSheet component within a Blazor app.
/// </summary>
public static class AppBottomSheetExtensions
{
    /// <summary>
    /// Creates and configures a BottomSheet with the specified component and options.
    /// </summary>
    /// <typeparam name="TComponent">The component to render inside the BottomSheet.</typeparam>
    /// <param name="navigation">The current <see cref="INavigation"/> instance for navigation control.</param>
    /// <param name="options">Optional configuration options for the BottomSheet.</param>
    /// <param name="parameters">Optional parameters to pass to the component within the BottomSheet.</param>
    /// <returns>A task that represents the asynchronous creation of the BottomSheet.</returns>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="navigation"/> is null.</exception>
    public static Task<TMB.BottomSheet> CreateBottomSheetAsync<TComponent>(this INavigation navigation, BottomSheetOptions? options = null, Dictionary<string, object>? parameters = null) where TComponent : IComponent
    {
        ArgumentNullException.ThrowIfNull(navigation);

        var body = new RenderFragment(builder => BuildContent<TComponent>(builder, parameters));

        return ((Navigation)navigation).BuildElement<TMB.BottomSheet>(typeof(AppBottomSheet), new Dictionary<string, object?>
        {
            [nameof(AppBottomSheet.Title)] = options?.Title,
            [nameof(AppBottomSheet.Body)] = body,
        });
    }

    #region Private Helpers

    /// <summary>
    /// Builds the content for the BottomSheet component with optional parameters.
    /// </summary>
    /// <typeparam name="TComponent">The type of the component to render inside the BottomSheet.</typeparam>
    /// <param name="builder">The RenderTreeBuilder used to construct the component's rendering tree.</param>
    /// <param name="parameters">Optional parameters to pass to the component.</param>
    private static void BuildContent<TComponent>(RenderTreeBuilder builder, Dictionary<string, object>? parameters) where TComponent : IComponent
    {
        int sequence = 0;
        builder.OpenComponent<TComponent>(sequence++);
        if (parameters != null)
        {
            foreach (var (key, value) in parameters)
            {
                builder.AddComponentParameter(sequence++, key, value);
            }
        }
        builder.CloseComponent();
    }

    #endregion
}

/// <summary>
/// Options to configure the BottomSheet display and behavior.
/// </summary>
public sealed class BottomSheetOptions
{
    /// <summary>
    /// The title of the BottomSheet.
    /// </summary>
    public string? Title { get; set; }
}
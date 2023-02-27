using Microsoft.AspNetCore.Components;
using Piral.Blazor.Utils;

namespace Framework.Core;

[PiralComponent]
public abstract class BaseComponent : ComponentBase
{
    /// <summary>
    /// User class names, separated by space
    /// </summary>
    [Parameter] public string Class { get; set; } = "";

    /// <summary>
    /// User styles, applied on top of the component's own classes and styles
    /// </summary>
    [Parameter] public string Style { get; set; } = "";

    /// <summary>
    /// Gets or sets a collection of additional attributes that will be applied to the created element.
    /// </summary>
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object> AdditionalAttributes { get; set; } = new();
}

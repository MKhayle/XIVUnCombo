using System;

namespace XIVUncombo.Attributes;

/// <summary>
/// Attribute documenting required combo relationships.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
internal class ParentUncomboAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ParentUncomboAttribute"/> class.
    /// </summary>
    /// <param name="parentPreset">Presets that depend on the given combo.</param>
    internal ParentUncomboAttribute(CustomUncomboPreset parentPreset)
    {
        this.ParentPreset = parentPreset;
    }

    /// <summary>
    /// Gets the display name.
    /// </summary>
    public CustomUncomboPreset ParentPreset { get; }
}

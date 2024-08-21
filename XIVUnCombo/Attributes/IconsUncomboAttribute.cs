using System;

namespace XIVUncombo.Attributes;

/// <summary>
/// Attribute designating icons to display in action presets.
/// </summary>
[AttributeUsage(AttributeTargets.Field)]
internal class IconsUncomboAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IconsUncomboAttribute"/> class with a single icon.
    /// </summary>
    /// <param name="icon">Icon that should be displayed next to the action preset.</param>
    internal IconsUncomboAttribute(uint icon)
    {
        this.Icons = [icon];
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IconsUncomboAttribute"/> class with up to 3 icons.
    /// </summary>
    /// <param name="icons">Array of icon that should be displayed next to the action preset.</param>
    internal IconsUncomboAttribute(uint[] icons)
    {
            this.Icons = icons;
    }

    /// <summary>
    /// Gets the icon ID.
    /// </summary>
    public uint[] Icons { get; }

    public const uint

        // General utility icons
        Blank = 61699,
        ArrowLeft = 66301,
        ArrowRight = 66302,
        ArrowUp = 66303,
        ArrowDown = 66304,
        Checkmark = 66311,
        Cycle = 66329;

}
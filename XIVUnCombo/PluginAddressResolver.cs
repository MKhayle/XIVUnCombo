using System;

using Dalamud.Game;

namespace XIVUncombo;

/// <summary>
/// Plugin address resolver.
/// </summary>
internal class PluginAddressResolver : BaseAddressResolver
{
    /// <summary>
    /// Gets the address of fpIsIconReplacable.
    /// </summary>
    public IntPtr IsActionIdReplaceable { get; private set; }

    /// <inheritdoc/>
    protected unsafe override void Setup64Bit(ISigScanner scanner)
    {


        this.IsActionIdReplaceable = scanner.ScanText("E8 ?? ?? ?? ?? 84 C0 0F 84 ?? ?? ?? ?? C6 83 ?? ?? ?? ?? ?? 48 8B 5C 24");

        Service.PluginLog.Verbose("===== X I V C O M B O =====");
        Service.PluginLog.Verbose($"{nameof(this.IsActionIdReplaceable)} 0x{this.IsActionIdReplaceable:X}");
    }
}

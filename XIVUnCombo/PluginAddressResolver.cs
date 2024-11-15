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


        this.IsActionIdReplaceable = scanner.ScanText("40 53 48 83 EC 20 8B D9 48 8B 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 85 C0 74 1B");

        Service.PluginLog.Verbose("===== X I V U N C O M B O =====");
        Service.PluginLog.Verbose($"{nameof(this.IsActionIdReplaceable)} 0x{this.IsActionIdReplaceable:X}");
    }
}

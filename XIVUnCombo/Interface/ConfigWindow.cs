using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

using Dalamud.Interface;
using Dalamud.Interface.Colors;
using Dalamud.Interface.Textures;
using Dalamud.Interface.Utility.Raii;
using Dalamud.Interface.Windowing;
using Dalamud.Utility;
using ImGuiNET;
using XIVUncombo.Attributes;
using XIVUncombo.Combos;

using Action = Lumina.Excel.GeneratedSheets.Action;
using Language = Lumina.Data.Language;

namespace XIVUncombo.Interface;

/// <summary>
/// Plugin configuration window.
/// </summary>
public class ConfigWindow : Window
{
    private readonly Dictionary<string, List<(CustomComboPreset Preset, CustomComboInfoAttribute Info)>> groupedPresets;
    private readonly Dictionary<CustomComboPreset, (CustomComboPreset Preset, CustomComboInfoAttribute Info)[]> presetChildren;
    private readonly Vector4 shadedColor = new(0.68f, 0.68f, 0.68f, 1.0f);
    private XIVUncombo Plugin;

    /// <summary>
    /// Initializes a new instance of the <see cref="ConfigWindow"/> class.
    /// </summary>
    public ConfigWindow(XIVUncombo Plugin)
        : base($"XIV Uncombo v{Service.Interface.Manifest.AssemblyVersion}")
    {
        this.Plugin = Plugin;
        this.RespectCloseHotkey = true;

        this.groupedPresets = Enum
            .GetValues<CustomComboPreset>()
            .Where(preset => (int)preset > 100 && preset != CustomComboPreset.Disabled)
            .Select(preset => (Preset: preset, Info: preset.GetAttribute<CustomComboInfoAttribute>()))
            .Where(tpl => tpl.Info != null && Service.Configuration.GetParent(tpl.Preset) == null)
            .OrderBy(tpl => CustomComboInfoAttribute.RoleIDToOrder(tpl.Info.RoleName))
            .ThenBy(tpl => tpl.Info.JobID)
            .ThenBy(tpl => tpl.Info.Order)
            .GroupBy(tpl => tpl.Info.JobName)
            .ToDictionary(
                tpl => tpl.Key,
                tpl => tpl.ToList());

        var childCombos = Enum.GetValues<CustomComboPreset>().ToDictionary(
            tpl => tpl,
            tpl => new List<CustomComboPreset>());

        foreach (var preset in Enum.GetValues<CustomComboPreset>())
        {
            var parent = preset.GetAttribute<ParentComboAttribute>()?.ParentPreset;
            if (parent != null)
                childCombos[parent.Value].Add(preset);
        }

        this.presetChildren = childCombos.ToDictionary(
            kvp => kvp.Key,
            kvp => kvp.Value
                .Select(preset => (Preset: preset, Info: preset.GetAttribute<CustomComboInfoAttribute>()))
                .OrderBy(tpl => tpl.Info.Order).ToArray());

        this.SizeCondition = ImGuiCond.FirstUseEver;
        this.Size = new Vector2(500, 400);
        WindowSizeConstraints windowSizeConstraints = new WindowSizeConstraints();
        if (Service.Configuration.BigComboIcons || Service.Configuration.BigJobIcons)
            windowSizeConstraints.MinimumSize = new Vector2(700, 500);
        else
            windowSizeConstraints.MinimumSize = new Vector2(500, 400);
        this.SizeConstraints = windowSizeConstraints;
    }

    /// <inheritdoc/>
    public override void Draw()
    {
        using (ImRaii.PushStyle(ImGuiStyleVar.WindowPadding, new System.Numerics.Vector2(8f, 8f)))
        {
            if (!Service.Configuration.HideKofi)
            {
                ImGui.SetCursorPosX(ImGui.GetCursorPosX() + ImGui.GetColumnWidth() - 80f - ImGui.GetScrollX()
                                       - 2 * ImGui.GetStyle().ItemSpacing.X);
                using (ImRaii.PushColor(ImGuiCol.Button, ImGuiColors.DalamudRed))
                {
                    if (ImGui.Button("My Ko-Fi link ♥"))
                    {
                        Process.Start(new ProcessStartInfo { FileName = "https://ko-fi.com/khayle", UseShellExecute = true });
                    }
                }

                ImGui.SameLine();

                ImGui.SetCursorPosX(8f);
            }

            using (var generalTabs = ImRaii.TabBar("Tabs"))
            {
                if (generalTabs)
                {
                    #region COMBOS TAB

                    using (var combosTab = ImRaii.TabItem("Combos"))
                    {
                        if (combosTab)
                        {
                            if (!(Service.Configuration.CurrentJobTab is "Paladin" or "Monk" or "Warrior" or "Dragoon" or "Bard"
                                or "Black Mage" or "Summoner" or "Ninja" or "Machinist" or "Dark Knight" or "Astrologian"
                                or "Samurai" or "Red Mage" or "Gunbreaker" or "Dancer" or "Reaper" or "Viper" or "Pictomancer"))
                            {
                                Service.Configuration.CurrentJobTab = "Paladin";
                                Service.Configuration.Save();
                            }

                            float scale = 1f;
                            if (Service.Configuration.BigJobIcons)
                                scale = 1.5f;
                            if (ImGui.BeginChild("TabButtons", new System.Numerics.Vector2(36f * scale, 0f), false, ImGuiWindowFlags.NoScrollbar))
                            {
                                ImGui.SameLine(1f);

                                using (ImRaii.PushStyle(ImGuiStyleVar.FramePadding, new System.Numerics.Vector2(4f, 3f)))
                                {
                                    if (ImGui.BeginTable("TabButtonsTable", 1, ImGuiTableFlags.None, new System.Numerics.Vector2(36f * scale, 36f * scale), 4f * scale))
                                    {
                                        if (Service.Configuration.CurrentJobTab is "Adventurer" or "Disciples of the Hand" or "Disciples of the Land" or "White Mage" or "Sage" or "Scholar")
                                        {
                                            Service.Configuration.CurrentJobTab = "Paladin";
                                        }

                                        foreach (var jobName in this.groupedPresets.Keys)
                                        {
                                            if ((jobName is "Adventurer" or "Disciples of the Hand" or "Disciples of the Land" or "White Mage" or "Sage" or "Scholar"))
                                            {
                                            }
                                            else
                                            {
                                                ImGui.TableNextRow();
                                                ImGui.TableNextColumn();
                                                ImGui.PushID($"EditorTab{CustomComboInfoAttribute.NameToJobID(jobName)}");
                                                bool selected = Service.Configuration.CurrentJobTab == jobName ? true : false;

                                                using (selected ? ImRaii.PushColor(ImGuiCol.Button, ImGuiColors.DalamudGrey2) : ImRaii.PushColor(ImGuiCol.Button, 0))
                                                using (selected ? ImRaii.PushColor(ImGuiCol.Border, ImGuiColors.DalamudGrey3) : ImRaii.PushColor(ImGuiCol.Border, 0))
                                                using (ImRaii.PushStyle(ImGuiStyleVar.FramePadding, new System.Numerics.Vector2(4f, 3f)))
                                                using (ImRaii.PushStyle(ImGuiStyleVar.FrameBorderSize, 0))
                                                {
                                                    ISharedImmediateTexture image = GetJobIcon(CustomComboInfoAttribute.NameToJobID(jobName));

                                                    if (image != null)
                                                    {
                                                        if (ImGui.ImageButton(image.GetWrapOrEmpty().ImGuiHandle, new System.Numerics.Vector2(28f * scale, 28f * scale)))
                                                        {
                                                            Service.Configuration.CurrentJobTab = jobName;
                                                        }

                                                        if (ImGui.IsItemHovered())
                                                        {
                                                            ImGui.BeginTooltip();
                                                            ImGui.TextUnformatted(jobName);
                                                            ImGui.EndTooltip();
                                                        }
                                                    }
                                                }

                                                ImGui.PopID();
                                            }
                                        }

                                        ImGui.EndTable();
                                    }
                                }

                                ImGui.EndChild();
                            }

                            ImGui.SameLine();

                            ImGui.BeginGroup();

                            ImGui.Indent(-10f);
                            if (ImGui.BeginChild("TabContent", new Vector2(0, -1), true, ImGuiWindowFlags.NoBackground))
                            {
                                #region COMBOS TAB HEADER
                                var jobID = CustomComboInfoAttribute.NameToJobID(Service.Configuration.CurrentJobTab);
                                var image = GetJobIcon(jobID);
                                ImGui.Image(image.GetWrapOrEmpty().ImGuiHandle, new System.Numerics.Vector2(36f, 36f));
                                ImGui.SameLine();
                                using (ImRaii.PushFont(UiBuilder.MonoFont))
                                using (ImRaii.PushColor(ImGuiCol.Text, ImGuiColors.ParsedGold))
                                {
                                    ImGui.Text($" " + Service.Configuration.CurrentJobTab + "\n " + (CustomComboInfoAttribute.JobIDToRole(jobID) != "Adventurer" ? CustomComboInfoAttribute.JobIDToRole(jobID) : "Warrior of Light"));
                                }

                                ImGui.Separator();
                                #endregion

                                if (Service.Configuration.CurrentJobTab is not "Adventurer" or "Disciples of the Hand" or "Disciples of the Land" or "White Mage" or "Sage" or "Scholar")
                                {
                                    ImGui.BeginChild("scrolling", new Vector2(0, -1), true);

                                    int i = 1;
                                    foreach (var (preset, info) in this.groupedPresets[Service.Configuration.CurrentJobTab])
                                    {
                                        this.DrawPreset(preset, info, ref i);
                                    }

                                    ImGui.EndChild();
                                }


                                ImGui.EndChild();
                            }

                            ImGui.Unindent();

                            ImGui.EndGroup();
                        }
                    }
                    #endregion

                    #region SETTINGS TAB

                    using (var settingsTab = ImRaii.TabItem("Settings"))
                    {
                        if (settingsTab)
                        {
                            ImGuiWindowFlags window_flags = ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.ChildWindow;
                            using (ImRaii.PushStyle(ImGuiStyleVar.ItemSpacing, new Vector2(0, 5)))
                            {
                                ImGui.Spacing();
                                ImGui.Spacing();

                                using (ImRaii.PushFont(UiBuilder.MonoFont))
                                using (ImRaii.PushColor(ImGuiCol.Text, ImGuiColors.ParsedGold))
                                {
                                    ImGui.Text($"General Options");
                                }

                                ImGui.Separator();

                                var enablePlugin = Service.Configuration.EnablePlugin;
                                if (ImGui.Checkbox("Enables this plugin.", ref enablePlugin))
                                {
                                    Service.Configuration.EnablePlugin = enablePlugin;
                                    Service.Configuration.Save();
                                }

                                if (ImGui.IsItemHovered())
                                {
                                    ImGui.BeginTooltip();
                                    ImGui.TextUnformatted("Completely disables the plugin's functionalities along with every combo when unchecked.");
                                    ImGui.EndTooltip();
                                }

                                var autoJobChange = Service.Configuration.AutoJobChange;
                                if (ImGui.Checkbox("Automatically switch to your current job's tab upon opening the UI.", ref autoJobChange))
                                {
                                    Service.Configuration.AutoJobChange = autoJobChange;
                                    Service.Configuration.Save();
                                }

                                var bigComboIcons = Service.Configuration.BigComboIcons;
                                if (ImGui.Checkbox("Increase the size of icons for uncombos.", ref bigComboIcons))
                                {
                                    Service.Configuration.BigComboIcons = bigComboIcons;
                                    Service.Configuration.Save();
                                }

                                var bigJobIcons = Service.Configuration.BigJobIcons;
                                if (ImGui.Checkbox("Increase the size of icons for the jobs on the side bar.", ref bigJobIcons))
                                {
                                    Service.Configuration.BigJobIcons = bigJobIcons;
                                    Service.Configuration.Save();
                                }

                                var hideIcons = Service.Configuration.HideIcons;
                                if (ImGui.Checkbox("Hide icons for uncombos.", ref hideIcons))
                                {
                                    Service.Configuration.HideIcons = hideIcons;
                                    Service.Configuration.Save();
                                }

                                var hideKoFi = Service.Configuration.HideKofi;
                                if (ImGui.Checkbox("Hide the Ko-Fi link.", ref hideKoFi))
                                {
                                    Service.Configuration.HideKofi = hideKoFi;
                                    Service.Configuration.Save();
                                }

                            }

                            ImGui.SameLine();
                        }
                    }
                    #endregion

                    #region ABOUT TAB
                    using (var aboutTab = ImRaii.TabItem("About"))
                    {
                        if (aboutTab)
                        {
                            ImGui.Spacing();
                            ImGui.Spacing();

                            using (ImRaii.PushFont(UiBuilder.MonoFont))
                            using (ImRaii.PushColor(ImGuiCol.Text, ImGuiColors.DalamudWhite2))
                            {
                                ImGui.Text("GitHub Repository");
                            }

                            ImGui.Separator();
                            ImGui.Spacing();

                            var url = "https://github.com/MKhayle/XIVUncombo";
                            if (ImGui.Button("Open the GitHub Repository URL"))
                            {
                                Process.Start(new ProcessStartInfo { FileName = url, UseShellExecute = true });
                            }

                            ImGui.Spacing();
                            ImGui.Spacing();

                            using (ImRaii.PushFont(UiBuilder.MonoFont))
                            using (ImRaii.PushColor(ImGuiCol.Text, ImGuiColors.DalamudWhite2))
                            {
                                ImGui.Text("Contributors and special thanks");
                            }

                            ImGui.Separator();
                            ImGui.Spacing();

                            ImGui.BulletText("goat and the whole Dalamud team");
                            ImGui.BulletText("ff-meli for the initial concept");
                            ImGui.BulletText("attick for XIVCombo");
                            ImGui.BulletText("daemitus for XIVUncombo's basecode");
                        }
                    }
                    #endregion
                }
            }
        }
    }


    private void DrawPreset(CustomComboPreset preset, CustomComboInfoAttribute info, ref int i)
    {
        var enabled = Service.Configuration.IsEnabled(preset);
        var parent = Service.Configuration.GetParent(preset);
        uint[] icons = [];

        if (preset.GetAttribute<IconsComboAttribute>()?.Icons.Length > 0)
            icons = preset.GetAttribute<IconsComboAttribute>().Icons;


        ImGui.PushItemWidth(200);

        if (ImGui.Checkbox(info.FancyName, ref enabled))
        {
            if (enabled)
            {
                this.EnableParentPresets(preset);
                var children = this.presetChildren[preset];
                if (children.Length > 0)
                {
                    foreach (var (childPreset, childInfo) in children)
                        Service.Configuration.EnabledActions.Add(childPreset);
                }

                Service.Configuration.EnabledActions.Add(preset);
            }
            else
            {
                Service.Configuration.EnabledActions.Remove(preset);
            }

            Service.Configuration.Save();
        }

        ImGui.PopItemWidth();

        using (ImRaii.PushColor(ImGuiCol.Text, this.shadedColor))
        {
            ImGui.TextWrapped($"{info.Description}");
        }

        float scale = 1;
        if (Service.Configuration.BigComboIcons)
            scale = 1.3f;

        if (icons.Length > 0 && !Service.Configuration.HideIcons)
        {
            int it = 0;
            foreach (var iconId in icons)
            {
                ImGui.AlignTextToFramePadding();
                bool isUTL = false;
                string hoverName = string.Empty;
                ISharedImmediateTexture icon;

                // Workaround which will work until it won't work anymore
                if (iconId > 60000)
                {
                    icon = GetIcon(iconId);
                    isUTL = true;
                }
                else
                {
                    icon = GetSkillIcon(iconId);
                }

                if (isUTL)
                {
                    ImGui.Image(GetIcon(IconsComboAttribute.Blank).GetWrapOrEmpty().ImGuiHandle, new System.Numerics.Vector2(2f * scale, 24f * scale));
                    ImGui.SameLine(0, 0);
                    ImGui.SetCursorPosY(ImGui.GetCursorPosY() + 3f);
                    ImGui.Image(icon.GetWrapOrEmpty().ImGuiHandle, new System.Numerics.Vector2(20f * scale, 20f * scale));
                    ImGui.SetCursorPosY(ImGui.GetCursorPosY() - 3f);
                }
                else
                {
                    ImGui.Image(icon.GetWrapOrEmpty().ImGuiHandle, new System.Numerics.Vector2(24f * scale, 24f * scale));
                    hoverName = GetSkillName(iconId);
                }

                if (hoverName != string.Empty)
                {
                    if (ImGui.IsItemHovered())
                    {
                        ImGui.BeginTooltip();
                        ImGui.TextUnformatted(hoverName);
                        ImGui.EndTooltip();
                    }
                }

                if (isUTL)
                {
                    ImGui.SameLine(0, 0);
                    ImGui.Image(GetIcon(IconsComboAttribute.Blank).GetWrapOrEmpty().ImGuiHandle, new System.Numerics.Vector2(2f * scale, 24f * scale));
                }

                it++;

                if (icons.Count() != it)
                {
                    ImGui.SameLine();
                }
                else
                {
                    it = 0;
                }
            }

        }

        ImGui.Spacing();
        ImGui.Spacing();
        ImGui.Spacing();

        i++;

        if (enabled)
        {
            var children = this.presetChildren[preset];
            if (children.Length > 0)
            {
                foreach (var (childPreset, childInfo) in children)
                    this.DrawPreset(childPreset, childInfo, ref i);
            }
        }
    }

    /// <summary>
    /// Iterates up a preset's parent tree, enabling each of them.
    /// </summary>
    /// <param name="preset">Combo preset to enabled.</param>
    private void EnableParentPresets(CustomComboPreset preset)
    {
        var parentMaybe = Service.Configuration.GetParent(preset);
        while (parentMaybe != null)
        {
            var parent = parentMaybe.Value;

            if (!Service.Configuration.EnabledActions.Contains(parent))
            {
                Service.Configuration.EnabledActions.Add(parent);
            }

            parentMaybe = Service.Configuration.GetParent(parent);
        }
    }

    /// <summary>
    /// Returns a ISharedImmediateTexture for the appropriate job.
    /// </summary>
    /// <param name="jobID">ID of the job.</param>
    private static ISharedImmediateTexture GetJobIcon(byte jobID)
    {
        var iconID = 62100 + jobID;

        // Outside of bounds, either DoL, DoH, or we messed up.
        if (iconID < 62101 || iconID > 62142)
            iconID = 62145;
        // Adventurer
        if (jobID == 0)
            iconID = 62146;

        return GetIcon((uint)iconID);
    }

    /// <summary>
    /// Returns a ISharedImmediateTexture for the appropriate skill.
    /// </summary>
    /// <param name="skillID">ID of the skill.</param>
    private static ISharedImmediateTexture GetSkillIcon(uint skillID)
    {

        List<uint> whiteList = new List<uint>();
        whiteList.Add((uint)ADV.VariantRaise2);

        var actionList = Service.DataManager.GameData.Excel.GetSheet<Action>();
        var skill = actionList.GetRow(skillID);
        // Check if the icon isn't Cure's AND isn't actually Cure
        if ((skill.Icon == 405 && skill.RowId != 120) || (!skill.IsPlayerAction && skill.ClassJobLevel == 0) && !whiteList.Contains(skillID))
            return null;
        return GetIcon((uint)skill.Icon);
    }

    /// <summary>
    /// Returns the localized string name for the appropriate skill/status.
    /// </summary>
    /// <param name="skillID">ID of the skill.</param>
    private static string GetSkillName(uint skillID)
    {
        if (skillID > 60000)
            return String.Empty;

        Language language = (Language)Service.ClientState.ClientLanguage + 1;
        if (language != Language.English)
        {
            var enActionList = Service.DataManager.GameData.Excel.GetSheet<Action>(Language.English);
            var enSkill = enActionList.GetRow(skillID);
            var level = enSkill.ClassJobLevel != 0 ? $" (lvl {enSkill.ClassJobLevel})" : string.Empty;
            var actionList = Service.DataManager.GameData.Excel.GetSheet<Action>(language);
            var skill = actionList.GetRow(skillID);
            return $"{skill.Name}\n{enSkill.Name}{level}";
        }
        else
        {
            var actionList = Service.DataManager.GameData.Excel.GetSheet<Action>(language);
            var skill = actionList.GetRow(skillID);
            var level = skill.ClassJobLevel != 0 ? $" (lvl {skill.ClassJobLevel})" : string.Empty;
            return $"{skill.Name}{level}";
        }

    }

    /// <summary>
    /// Returns a ISharedImmediateTexture for the appropriate icon.
    /// </summary>
    /// <param name="iconID">ID of the icon.</param>
    private static ISharedImmediateTexture GetIcon(uint iconID)
        => Service.TextureProvider.GetFromGameIcon(new GameIconLookup(iconID, false, true));
}

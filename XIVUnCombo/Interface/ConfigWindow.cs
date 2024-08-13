using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

using Dalamud.Interface;
using Dalamud.Interface.Colors;
using Dalamud.Interface.Textures;
using Dalamud.Interface.Windowing;
using Dalamud.Utility;
using ImGuiNET;
using Lumina.Excel.GeneratedSheets;
using Lumina.Excel.GeneratedSheets2;
using Newtonsoft.Json.Linq;
using XIVUncombo.Attributes;
using XIVUncombo.Combos;
using Action = Lumina.Excel.GeneratedSheets.Action;
using Language = Lumina.Data.Language;
using Status = Lumina.Excel.GeneratedSheets.Status;

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
        : base($"XIV Uncombo")
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
            .ThenBy(tpl => tpl.Preset.GetAttribute<SectionComboAttribute>()?.Section)
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
        if (ImGui.BeginTabBar("Tabs"))
        {
            #region COMBOS TAB

            if (ImGui.BeginTabItem("Combos"))
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

                    ImGui.PushStyleVar(ImGuiStyleVar.FramePadding, new System.Numerics.Vector2(4f, 3f));
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
                                if (selected)
                                {
                                    ImGui.PushStyleColor(ImGuiCol.Button, ImGuiColors.DalamudGrey2);
                                    ImGui.PushStyleColor(ImGuiCol.Border, ImGuiColors.DalamudGrey3);
                                }
                                else
                                {
                                    ImGui.PushStyleColor(ImGuiCol.Button, 0);
                                    ImGui.PushStyleColor(ImGuiCol.Border, 0);
                                }

                                ImGui.PushStyleVar(ImGuiStyleVar.FrameBorderSize, 0);

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

                                ImGui.PopStyleVar();
                                ImGui.PopStyleColor(2);
                                ImGui.PopID();
                            }
                        }

                        ImGui.EndTable();
                        ImGui.PopStyleVar();
                    }

                    ImGui.EndChild();
                }

                ImGui.SameLine();

                ImGui.BeginGroup();

                ImGui.PushStyleColor(ImGuiCol.ChildBg, ImGuiColors.DalamudWhite);
                ImGui.PushStyleColor(ImGuiCol.Border, ImGuiColors.DalamudWhite2);

                ImGui.Indent(-10f);
                if (ImGui.BeginChild("TabContent", new Vector2(0, -1), true, ImGuiWindowFlags.NoBackground))
                {
                    #region COMBOS TAB HEADER
                    var jobID = CustomComboInfoAttribute.NameToJobID(Service.Configuration.CurrentJobTab);
                    var image = GetJobIcon(jobID);
                    ImGui.Image(image.GetWrapOrEmpty().ImGuiHandle, new System.Numerics.Vector2(36f, 36f));
                    ImGui.SameLine();
                    ImGui.PushFont(UiBuilder.MonoFont);
                    ImGui.PushStyleColor(ImGuiCol.Text, ImGuiColors.ParsedGold);
                    ImGui.Text($" " + Service.Configuration.CurrentJobTab + "\n " + (CustomComboInfoAttribute.JobIDToRole(jobID) != "Adventurer" ? CustomComboInfoAttribute.JobIDToRole(jobID) : "Warrior of Light"));
                    ImGui.PopStyleColor();
                    ImGui.PopFont();
                    ImGui.Separator();
                    ImGui.PopStyleColor(2);
                    #endregion

                    if (Service.Configuration.CurrentJobTab is not "Adventurer" or "Disciples of the Hand" or "Disciples of the Land" or "White Mage" or "Sage" or "Scholar")
                    {
                        ImGui.BeginChild("scrolling", new Vector2(0, -1), true);

                        int i = 1;
                        string previousSection = string.Empty;
                        foreach (var (preset, info) in this.groupedPresets[Service.Configuration.CurrentJobTab])
                        {
                            previousSection = this.DrawPreset(preset, info, previousSection, ref i);
                        }

                        ImGui.EndChild();
                    }


                    ImGui.EndChild();
                }

                ImGui.Unindent();

                ImGui.EndGroup();

                ImGui.EndTabItem();
            }
            #endregion

            #region SETTINGS TAB

            if (ImGui.BeginTabItem("Settings"))
            {
                ImGui.Spacing();
                ImGui.Spacing();
                ImGuiWindowFlags window_flags = ImGuiWindowFlags.NoScrollbar | ImGuiWindowFlags.ChildWindow;
                ImGui.PushStyleVar(ImGuiStyleVar.ChildRounding, 5f);
                ImGui.BeginChild("Child", new System.Numerics.Vector2(ImGui.GetContentRegionAvail().X * 0.95f - ImGui.GetScrollX(), 300f), true, window_flags);

                ImGui.PushFont(UiBuilder.MonoFont);
                ImGui.PushStyleColor(ImGuiCol.Text, ImGuiColors.ParsedGold);
                ImGui.Text($"Settings");
                ImGui.PopStyleColor();
                ImGui.PopFont();
                ImGui.Separator();

                var enablePlugin = Service.Configuration.EnablePlugin;
                if (ImGui.Checkbox("Enable this plugin.", ref enablePlugin))
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
                if (ImGui.Checkbox("Hide icons for uncombos and features.", ref hideIcons))
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

                ImGui.Spacing();
                ImGui.Spacing();


                ImGui.EndChild();
                ImGui.PopStyleVar();
                ImGui.SameLine();

                ImGui.EndTabItem();
            }
        #endregion

        #region ABOUT TAB
            if (ImGui.BeginTabItem("About"))
            {

                ImGui.Spacing();
                ImGui.Spacing();
                ImGui.PushFont(UiBuilder.MonoFont);
                ImGui.PushStyleColor(ImGuiCol.Text, ImGuiColors.DalamudWhite2);
                ImGui.Text("Nerd Stats");
                ImGui.PopStyleColor();
                ImGui.PopFont();
                ImGui.Separator();
                ImGui.Spacing();

                ImGui.BulletText($"{Enum.GetValues<CustomComboPreset>().Where(preset => (int)preset > 100 && preset != CustomComboPreset.Disabled && Service.Configuration.IsEnabled(preset)).Count()} uncombos are currently enabled.");
                ImGui.BulletText($"{Enum.GetValues<CustomComboPreset>().Where(preset => (int)preset > 100 && preset != CustomComboPreset.Disabled).Count()} total uncombos are available.");

                ImGui.Separator();
                ImGui.Spacing();
                ImGui.Spacing();
                ImGui.PushFont(UiBuilder.MonoFont);
                ImGui.PushStyleColor(ImGuiCol.Text, ImGuiColors.DalamudWhite2);
                ImGui.Text("GitHub Repository");
                ImGui.PopStyleColor();
                ImGui.PopFont();
                ImGui.Separator();
                ImGui.Spacing();

                var url = "https://github.com/MKhayle/XIVUncombo";
                if (ImGui.Button("Open the GitHub Repository URL"))
                {
                    Process.Start(new ProcessStartInfo { FileName = "https://github.com/MKhayle/XIVUncombo", UseShellExecute = true });
                }

                ImGui.Spacing();
                ImGui.Spacing();
                ImGui.PushFont(UiBuilder.MonoFont);
                ImGui.PushStyleColor(ImGuiCol.Text, ImGuiColors.DalamudWhite2);
                ImGui.Text("Contributors and special thanks");
                ImGui.PopStyleColor();
                ImGui.PopFont();
                ImGui.Separator();
                ImGui.Spacing();

                ImGui.BulletText("goat and the whole Dalamud team");
                ImGui.BulletText("ff-meli for the initial concept");
                ImGui.BulletText("attick for XIVCombo");
                ImGui.BulletText("daemitus for XIVUncombo's basecode");


                if (!Service.Configuration.HideKofi)
                {
                    ImGui.PushStyleColor(ImGuiCol.Button, ImGuiColors.DalamudRed);

                    if (ImGui.Button("My Ko-Fi link ♥"))
                    {
                        Process.Start(new ProcessStartInfo { FileName = "https://ko-fi.com/khayle", UseShellExecute = true });
                    }

                    ImGui.PopStyleColor();
                }

                ImGui.EndTabItem();
            }
            #endregion


        }

        ImGui.EndTabBar();
        ImGui.SameLine();
        ImGui.SetCursorPosX(ImGui.GetCursorPosX() + ImGui.GetColumnWidth() - 80f - ImGui.GetScrollX()
                               - 2 * ImGui.GetStyle().ItemSpacing.X);
    }

    private void DrawSection(CustomComboPreset preset, CustomComboInfoAttribute info, ref int i)
    {
        var enabled = Service.Configuration.IsEnabled(preset);
        var conflicts = Service.Configuration.GetConflicts(preset);
        var parent = Service.Configuration.GetParent(preset);
        string section = preset.GetAttribute<SectionComboAttribute>()?.Section;
        uint[] icons = [];

        ImGui.Spacing();
        ImGui.Spacing();
        ImGui.PushFont(UiBuilder.MonoFont);
        ImGui.PushStyleColor(ImGuiCol.Text, ImGuiColors.ParsedOrange);
        ImGui.Text(section);
        ImGui.PopStyleColor();
        ImGui.PopFont();
        ImGui.Separator();
        ImGui.Spacing();
    }

    private string DrawPreset(CustomComboPreset preset, CustomComboInfoAttribute info, string previousSection, ref int i)
    {
        var enabled = Service.Configuration.IsEnabled(preset);
        var conflicts = Service.Configuration.GetConflicts(preset);
        var parent = Service.Configuration.GetParent(preset);
        uint[] icons = [];
        string section = string.Empty;

        if (preset.GetAttribute<IconsComboAttribute>()?.Icons.Length > 0)
            icons = preset.GetAttribute<IconsComboAttribute>().Icons;
        if (preset.GetAttribute<SectionComboAttribute>()?.Section != null)
            section = preset.GetAttribute<SectionComboAttribute>().Section.ToString();


        if (preset.GetAttribute<SectionComboAttribute>()?.Section != null)
        {
            if (previousSection != preset.GetAttribute<SectionComboAttribute>()?.Section && previousSection != "child")
            {
                this.DrawSection(preset, info, ref i);
                previousSection = preset.GetAttribute<SectionComboAttribute>()?.Section;
            }
        }


        ImGui.PushItemWidth(200);

        if (ImGui.Checkbox(info.FancyName, ref enabled))
        {
            if (enabled)
            {
                this.EnableParentPresets(preset);
                Service.Configuration.EnabledActions.Add(preset);
                foreach (var conflict in conflicts)
                {
                    Service.Configuration.EnabledActions.Remove(conflict);
                }
            }
            else
            {
                Service.Configuration.EnabledActions.Remove(preset);
            }

            Service.Configuration.Save();
        }

        float scale = 1;
        if (Service.Configuration.BigComboIcons)
            scale = 1.3f;


        if (icons.Length > 0 && !Service.Configuration.HideIcons)
        {
            ImGui.SameLine();
            ImGui.SetCursorPosX(
              ImGui.GetCursorPosX()
              + ImGui.GetColumnWidth()
              - (icons.Length * ((24f * scale) + (float)ImGui.GetStyle().ItemSpacing.X))
              + ImGui.GetScrollX());


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

        ImGui.PopItemWidth();

        ImGui.PushStyleColor(ImGuiCol.Text, this.shadedColor);
        ImGui.TextWrapped($"{info.Description}");
        ImGui.PopStyleColor();
        ImGui.Spacing();

        if (conflicts.Length > 0 && enabled)
        {
            var conflictText = conflicts.Select(conflict =>
            {
                var conflictInfo = conflict.GetAttribute<CustomComboInfoAttribute>();
                return $" · {conflictInfo.FancyName}";
            }).Aggregate((t1, t2) => $"{t1}{t2}");

            if (conflictText.Length > 0)
            {
                ImGui.TextColored(ImGuiColors.DPSRed, $"Conflicts with {conflictText}");
                ImGui.Spacing();
            }
        }

        i++;

        var hideChildren = Service.Configuration.HideChildren;
        if (enabled || !hideChildren)
        {
            var children = this.presetChildren[preset];
            if (children.Length > 0)
            {
                ImGui.Indent();

                foreach (var (childPreset, childInfo) in children)
                    this.DrawPreset(childPreset, childInfo, "child", ref i);

                ImGui.Unindent();
            }
        }

        return section;
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
                foreach (var conflict in Service.Configuration.GetConflicts(parent))
                {
                    Service.Configuration.EnabledActions.Remove(conflict);
                }
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
        var actionList = Service.DataManager.GameData.Excel.GetSheet<Action>(language);
        var skill = actionList.GetRow(skillID);
        return skill.Name;

    }

    /// <summary>
    /// Returns a ISharedImmediateTexture for the appropriate icon.
    /// </summary>
    /// <param name="iconID">ID of the icon.</param>
    private static ISharedImmediateTexture GetIcon(uint iconID)
        => Service.TextureProvider.GetFromGameIcon(new GameIconLookup(iconID, false, true));
}

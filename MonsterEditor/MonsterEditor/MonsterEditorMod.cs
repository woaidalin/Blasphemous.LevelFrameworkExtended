using System.Collections;
using Blasphemous.ModdingAPI;
using MonsterEditor.Components;
using UnityEngine;

namespace MonsterEditor;

/// <summary>
/// Registers the monster catalogue as level objects and starts the in-game editor
/// once, so the same build supports both level edits and live spawning.
/// </summary>
public class MonsterEditorMod : BlasMod
{
    private static bool _toolCreated;

    internal MonsterEditorMod()
        : base(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_AUTHOR, ModInfo.MOD_VERSION)
    {
    }

    /// <inheritdoc/>
    protected override void OnRegisterServices(ModServiceProvider provider)
    {
        foreach (LevelObjectEntry entry in MonsterEditorObjects.CreateAll())
        {
            entry.Register(provider);
        }
    }

    /// <inheritdoc/>
    protected override void OnLevelLoaded(string oldLevel, string newLevel)
    {
        MonsterEditorTool.CaptureLevelConfig();

        if (_toolCreated)
        {
            return;
        }

        _toolCreated = true;
        GameObject tool = new GameObject("MonsterEditorTool");
        Object.DontDestroyOnLoad(tool);
        tool.AddComponent<MonsterEditorTool>();
        ModLog.Info("Monster editor tool created");
    }
}

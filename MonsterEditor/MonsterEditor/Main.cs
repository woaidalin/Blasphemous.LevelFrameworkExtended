using BepInEx;

namespace MonsterEditor;

[BepInPlugin(ModInfo.MOD_ID, ModInfo.MOD_NAME, ModInfo.MOD_VERSION)]
[BepInDependency("Blasphemous.ModdingAPI", "3.0.1")]
[BepInDependency("Blasphemous.Framework.Levels", "0.2.0")]
internal class Main : BaseUnityPlugin
{
    /// <summary>Gets the plugin instance, used to host coroutines.</summary>
    public static Main Instance { get; private set; }

    /// <summary>Gets the mod instance.</summary>
    public static MonsterEditorMod Mod { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        Mod = new MonsterEditorMod();
    }
}

namespace MonsterEditor.Components;

/// <summary>
/// One editable monster: its catalogue id, display name, and the spawn-point template it
/// is cloned from.
/// </summary>
internal sealed class MonsterEntry
{
    internal MonsterEntry(string id, string name, string scene, string path, float lift)
    {
        Id = id;
        Name = name;
        Scene = scene;
        Path = path;
        Lift = lift;
    }

    /// <summary>Gets the catalogue id, for example <c>EN04</c>.</summary>
    internal string Id { get; }

    /// <summary>Gets the display name shown in the editor.</summary>
    internal string Name { get; }

    /// <summary>Gets the source logic scene that holds a ready-made spawn point.</summary>
    internal string Scene { get; }

    /// <summary>Gets the hierarchy path of that spawn point inside the scene.</summary>
    internal string Path { get; }

    /// <summary>Gets the vertical offset so ground monsters start above the floor.</summary>
    internal float Lift { get; }
}
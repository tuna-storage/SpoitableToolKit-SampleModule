using SpoitableToolKit.Abstractions;

namespace MyPlugin;

/// <summary>
/// The smallest plugin. Its Id and name come from the csproj (the build generates <c>PluginInfo</c>).
/// </summary>
public sealed class MyPlugin : IToolPlugin
{
    public string Id => PluginInfo.Id;

    public string DisplayName => PluginInfo.Name;

    public bool OnInit(IToolHost host) => true;
}

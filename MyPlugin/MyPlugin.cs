using SpoitableToolKit.Abstractions;

namespace MyPlugin;

/// <summary>
/// The smallest plugin. Its Id and name come from the csproj (the build generates <c>ModuleInfo</c>).
/// </summary>
public sealed class MyPlugin : IToolPlugin
{
    public string Id => ModuleInfo.Id;

    public string DisplayName => ModuleInfo.Name;

    public bool OnInit(IToolHost host) => true;
}

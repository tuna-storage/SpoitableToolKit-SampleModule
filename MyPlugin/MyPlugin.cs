using SpoitableToolKit.Abstractions;
using SpoitableToolKit.Abstractions.Ui;

namespace MyPlugin;

/// <summary>
/// The smallest plugin with a page. Its Id and name come from the csproj (the build generates <c>ModuleInfo</c>).
/// Implementing <see cref="IUiEndpoint"/> is what lists the page (<c>web/index.html</c>) in the app's sidebar.
/// </summary>
public sealed class MyPlugin : IToolPlugin, IUiEndpoint
{
    public string Id => ModuleInfo.Id;

    public string DisplayName => ModuleInfo.Name;

    public bool OnInit(IToolHost host) => true;

    /// <summary>The page calls nothing yet.</summary>
    public Task<string> HandleUiCallAsync(string method, string payload, CancellationToken cancellationToken = default) =>
        throw new NotSupportedException($"The sample plugin has no call named '{method}'.");
}

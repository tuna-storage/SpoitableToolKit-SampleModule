using SpoitableToolKit.Abstractions;

namespace MyPlugin;

/// <summary>
/// The smallest plugin with a page. Its Id and name come from the csproj: the build writes them into the dll, and
/// <see cref="IToolPlugin.Id"/> and <see cref="IToolPlugin.DisplayName"/> return them (do not write them here; the build stops with STK040).
/// <see cref="OnInit"/> registers the page (<c>web/index.html</c>) so that the app lists it in the sidebar
/// (forgetting it is warned about with STK041).
/// </summary>
public sealed class MyPlugin : IToolPlugin
{
    public bool OnInit(IToolHost host)
    {
        host.Ui.RegisterPanel("index.html");
        return true;
    }
}

using Microsoft.Extensions.Logging;
using SpoitableToolKit.Abstractions;

namespace MyModule;

/// <summary>
/// The smallest module with a page. Its Id and name come from the csproj: the build writes them into the dll, and
/// <see cref="ISpoitableModule.Id"/> and <see cref="ISpoitableModule.DisplayName"/> return them (do not write them here; the build stops with STK040).
/// <see cref="OnInit"/> registers the page (<c>web/index.html</c>) so that the app lists it in the sidebar
/// (forgetting it is warned about with STK041), and writes one line to the app's log through <see cref="IModuleHost.Logger"/>.
/// </summary>
public sealed class MyModule : ISpoitableModule
{
    public bool OnInit(IModuleHost host)
    {
        host.Ui.RegisterPanel("index.html");
        host.Logger.LogInformation("The sample module is running");
        return true;
    }
}

# SpoitableToolKit sample module

The smallest module for SpoitableToolKit: one page that shows a translated title.

## Install

In SpoitableToolKit, open Modules and add this repository's URL.

- If the repository has a release, the app installs the release's zip.
- Otherwise the app builds the source on your PC (it asks first).

## Layout

- `MyModule/MyModule.csproj` — the module's Id (`SpoitableModuleId`), name (`SpoitableModuleName`) and version
- `MyModule/MyModule.cs` — the entry class (`ISpoitableModule`). `OnInit` registers the page with `host.Ui.RegisterPanel("index.html")` so that it is listed in the sidebar, and logs through `host.Logger`
- `MyModule/web/` — the module's page (`index.html` is the entry; it loads `/_host/theme.css` and `/_host/bridge.js` from the app)
- `MyModule/locales/` — its texts

The build generates `ModuleInfo` (`Id`, `Name`, `Version` from the csproj) and writes the Id and the name into the dll; `ISpoitableModule.Id` and `DisplayName` return them, so the class does not write them (the build stops with STK040 if it does, and warns with STK041 if `web/index.html` is never registered). `ModuleInfo.ModuleDirectory` is the
folder the app loaded the module from; open a file the module ships with
`Path.Combine(ModuleInfo.ModuleDirectory, "some/file")` (read only: write to `IModuleHost.DataDirectory`).

`host.Logger` writes to the app's log under `SpoitableToolKit.Modules.<Id>`, so the log screen shows the line as this module's.

## Release

```
dotnet build MyModule -c Release -t:SpoitablePackModule
```

makes `MyModule/bin/module/mymodule-<version>-module.zip`. Attach it to a GitHub release.

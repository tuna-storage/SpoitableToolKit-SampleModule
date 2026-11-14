# SpoitableToolKit sample plugin

The smallest plugin for SpoitableToolKit: one page that shows a translated title.

## Install

In SpoitableToolKit, open Plugins and add this repository's URL.

- If the repository has a release, the app installs the release's zip.
- Otherwise the app builds the source on your PC (it asks first).

## Layout

- `MyPlugin/MyPlugin.csproj` — the plugin's Id (`SpoitablePluginId`), name and version
- `MyPlugin/MyPlugin.cs` — the entry class (`IToolPlugin`, and `IUiEndpoint` so that the page is listed in the sidebar)
- `MyPlugin/web/` — the plugin's page (`index.html` is the entry; it loads `/_host/theme.css` and `/_host/bridge.js` from the app)
- `MyPlugin/locales/` — its texts

The build generates `ModuleInfo` (`Id`, `Name`, `Version` from the csproj). `ModuleInfo.ModuleDirectory` is the
folder the app loaded the plugin from; open a file the plugin ships with
`Path.Combine(ModuleInfo.ModuleDirectory, "some/file")` (read only: write to `IToolHost.DataDirectory`).

## Release

```
dotnet build MyPlugin -c Release -t:SpoitablePackPlugin
```

makes `MyPlugin/bin/plugin/myplugin-<version>-plugin.zip`. Attach it to a GitHub release.

# SpoitableToolKit sample plugin

The smallest plugin for SpoitableToolKit: one page that shows a translated title.

## Install

In SpoitableToolKit, open Plugins and add this repository's URL.

- If the repository has a release, the app installs the release's zip.
- Otherwise the app builds the source on your PC (it asks first).

## Layout

- `MyPlugin/MyPlugin.csproj` — the plugin's Id (`SpoitablePluginId`), name and version
- `MyPlugin/MyPlugin.cs` — the entry class (`IToolPlugin`)
- `MyPlugin/web/` — the plugin's page
- `MyPlugin/locales/` — its texts

## Release

```
dotnet build MyPlugin -c Release -t:SpoitablePackPlugin
```

makes `MyPlugin/bin/plugin/myplugin-<version>-plugin.zip`. Attach it to a GitHub release.

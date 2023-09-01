# MinecraftLauncherConsole

This is for the people who are tired of carefully unpacking every new Minecraft Bedrock server release to avoid clobbering their modified files (although maybe that's mostly me...).

## Configuration

The launcher takes its configuration from the file `.\Config\config.json` in the same directory as the binary. The default configuration is below:
```json
{
    "DownloadPage": "https://www.minecraft.net/en-us/download/server/bedrock",
    "PreserveFiles": [
        "allowlist.json",
        "permissions.json",
        "server.properties",
        "worlds"
    ],
    "TargetDir": "C:\\Minecraft",
    "WorldName": "TestWorld"
}
```

### Parameters

* `TargetDir` is the parent directory where the unpacked servers are stored
* `WorldName` is where each server's contents will be unpacked
* `DownloadPage` is the link to the webpage where you download Bedrock server releases
* `PreserveFiles` is the list of files/directories you don't want overwritten when unpacking the new server

You shouldn't have to update the default `DownloadPage` or `PreserveFiles`, but if there is some kind of issue please post it.

## CLI
There isn't really a CLI, but the `WorldName` setting can be overridden by the first command line argument, e.g.:
```powershell
.\BedrockServerLauncher.exe Terraria
```

## Server Commands

The following server commands are currently supported:

```
kick <playerNameOrXuid> <reason>
stop
save [hold|resume|query]
allowlist [on|off|list|reload]
allowlist [add|remove] <playerNameOrXuid>
permission [list|reload]
op <playerNameOrXuid>
deop <playerNameOrXuid>
changesetting <setting> <value>
save hold
save query
save resume
```


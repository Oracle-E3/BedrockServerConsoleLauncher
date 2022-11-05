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
The `TargetDir` parameter is the parent directory and `WorldName` is where the server contents will be unpacked.

The `WorldName` setting can be overridden by the first command line argument, e.g.:

```powershell
.\BedrockServerLauncher.exe Terraria
```

Does not currently support server commands.

# PowerShell Human Readable File Sizes

![Screenshot](./screenshot.png)

## Quick Start

1. `csc /target:library CustomPowerShell.cs` to compile the custom format
   function into a loadable dll.
2. `.\launch.bat` to launch a powershell window with the custom profile
   loaded.
3. Run the `Get-ChildItem`.

## Installation

Copy the custom dll and the format description file next to your PowerShell
profile.

```powershell
cp .\CustomPowerShell.dll $HOME\Documents\PowerShell\
cp .\FileSystem.format.ps1xml $HOME\Documents\PowerShell\
```

Edit your PowerShell profile to include the snippet from the `profile.ps1` in
this repository.

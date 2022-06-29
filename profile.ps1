$CustomPowerShellDLLPath = "$PSScriptRoot\CustomPowerShell.dll"
if ([System.IO.File]::Exists($CustomPowerShellDLLPath)) {
    Import-Module $CustomPowerShellDLLPath
    Update-FormatData -PrependPath "$PSScriptRoot\FileSystem.format.ps1xml"
} else {
    Write-Warning "$CustomPowerShellDLLPath not found."
}

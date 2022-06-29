if (Import-Module "$PSScriptRoot\CustomPowerShell.dll" -PassThru -Force) {
    Update-FormatData -PrependPath "$PSScriptRoot\FileSystem.format.ps1xml"
}

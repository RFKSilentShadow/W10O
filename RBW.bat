@ECHO Uninstalling Microsoft Windows 10 BloatWare!
Powershell.exe -Command "& {Start-Process Powershell.exe -ArgumentList '-ExecutionPolicy Bypass -File %~dp0Windows10Debloater-master\Windows10Debloater.ps1' -Verb RunAs}"

EXIT
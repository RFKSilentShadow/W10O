@ECHO Your Windows 10 post-optimization has started!

@ECHO Disabling Microsoft Windows Defender!
START %~dp0dControl\dControl.exe /D
Powershell.exe -Command "& {Start-Process Powershell.exe -ArgumentList '-ExecutionPolicy Bypass -File %~dp0PSs\DefOFF2.ps1' -Verb RunAs}"
reg.exe ADD HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System /v EnableLUA /t REG_DWORD /d 0 /f
regedit /s %~dp0REGs\MASTERDEFKILL.reg

@ECHO Disabling Microsoft Windows UPDATE!
regedit /S %~dp0REGs\MASTERWUDKILL.reg

@ECHO Configuring Microsoft Windows Energy Settings!
powercfg /x -disk-timeout-ac 0
powercfg /x -disk-timeout-dc 0
powercfg /x -hibernate-timeout-ac 0
powercfg /x -hibernate-timeout-dc 0
powercfg /x -monitor-timeout-ac 0
powercfg /x -monitor-timeout-dc 0
powercfg /x -standby-timeout-ac 0
powercfg /x -standby-timeout-dc 0

@ECHO Removing remaining files!
del /S /q \%USERPROFILE%\AppData\Local\Temp\*
del /S /q C:\Windows\Temp\*
del /S /q C:\Windows\Prefetch\* 
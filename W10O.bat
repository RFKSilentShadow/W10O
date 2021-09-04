@ECHO Your Windows 10 optimization has started!

@ECHO Disabling Microsoft Windows Defender!
START %~dp0DEF\DEF.bat

@ECHO Disabling Microsoft Windows UPDATE!
START %~dp0WUD\WUD.bat

@ECHO Configuring Microsoft Windows Energy Settings!
START PWRMGMT.bat

@ECHO Uninstalling Microsoft Windows 10 BloatWare!
START RBW.bat

@ECHO Removing remaining files!
START RRF.bat

EXIT
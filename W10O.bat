@ECHO OFF

SET /p question=Full optimazition (f) or post optimazition (p):
IF "%question%" == "f" (
CALL :full
) ELSE (
IF "%question%" == "p" (
CALL :post
)
)


@ECHO ON

:startext

@ECHO Your Windows 10 optimization has started!

EXIT /B 0


:full

CALL :startext
CALL :post

@ECHO Configuring Microsoft Windows Energy Settings!
START PWRMGMT.bat

@ECHO Uninstalling Microsoft Windows 10 BloatWare!
START RBW.bat

@ECHO OFF

SET /p question2=Do you want reboot (y/n):
IF "%question2%" == "y" (
START R.bat
) ELSE (
IF "%question2%" == "n" (
EXIT
)
)

EXIT /B 0


:post

CALL :startext

@ECHO Your Windows 10 post-optimization has started!

@ECHO Disabling Microsoft Windows Defender!
START %~dp0DEF\DEF.bat

@ECHO Disabling Microsoft Windows UPDATE!
START %~dp0WUD\WUD.bat

@ECHO Removing remaining files!
START RRF.bat

@ECHO OFF

SET /p question2=Do you want reboot (y/n):
IF "%question2%" == "y" (
START R.bat
) ELSE (
IF "%question2%" == "n" (
EXIT
)
)

EXIT /B 0



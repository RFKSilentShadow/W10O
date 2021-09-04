@ECHO Your Windows 10 post-optimization has started!

@ECHO Disabling Microsoft Windows Defender!
START %~dp0DEF\DEF.bat

@ECHO Disabling Microsoft Windows UPDATE!
START %~dp0WUD\WUD.bat

@ECHO Removing remaining files!
START RRF.bat

EXIT
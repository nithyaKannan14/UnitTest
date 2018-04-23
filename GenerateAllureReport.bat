echo %DATE%
echo %TIME%
set datetimef=C:\FIZZBUZZAllureReports_%date:~-4%_%date:~3,2%_%date:~0,2%_%time:~0,2%_%time:~3,2%_%time:~6,2%
echo %datetimef%
cmd /k allure generate C:\Users\nithya.a.kannan\source\repos\FizzBuzz\NUnit-Gui-0.6.0\allure-results --clean -o %datetimef%
echo Press any key to exit
pause >nul

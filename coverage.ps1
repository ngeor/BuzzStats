.\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -register:user -filter:"+[Buzz*]* -[*.UnitTests]*" -target:.\packages\NUnit.ConsoleRunner.3.6.1\tools\nunit3-console.exe -targetargs:".\BuzzStats.MockServer.UnitTests\bin\Debug\BuzzStats.MockServer.UnitTests.dll .\BuzzStats.WebApi.UnitTests\bin\Debug\BuzzStats.WebApi.UnitTests.dll .\BuzzStats.UnitTests\bin\Debug\BuzzStats.UnitTests.dll"
.\packages\ReportGenerator.2.5.9\tools\ReportGenerator.exe -reports:results.xml -targetdir:coveragereport
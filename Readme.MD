# ASP.Net API Template

Simple ASP.Net API Template 

## Run 
* `dotnet run`

## Call Endpoints
* `curl http://localhost:5000/helloworld -L`
* `curl https://localhost:5001/helloworld`

## GitVersion
* Install with `choco install GitVersion.Portable` on windows or `brew install gitversion` using macos
* Tags on master define current version
* All commits on master increase patch (if not already increased) number and add appendix `+ <number of commits>`
* Adding version to a dotnet build with 
```
dotnet build /property:Version=`gitversion /output json /showvariable SemVer`
```
* Version in einem Branch sieht so aus `<MasterSemVer>-<branchname>.AnzahlCommits`
* 
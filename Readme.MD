# ASP.Net API Versioning using GitVersion

Simple ASP.Net API that uses GitVersion 

## Run 
* `dotnet run`

## Call Endpoints
* `curl http://localhost:5000/helloworld -L`
* `curl https://localhost:5001/helloworld`
* `curl http://localhost:5000/info -L`
* `curl https://localhost:5001/info`

## GitVersion
* Install with `choco install GitVersion.Portable` on windows or `brew install gitversion` using macos
* Tags on master can "reset" the current release version
* All commits on master increase patch (if not already increased) number and add appendix `+ <number of commits>`
* Feature branches have the following format: `SemVer-<branchname>.1+<number of commits>`
* Major, Minor or Patch can be increased explicitly by adding `+semver: major`, `+semver: minor` or `+semver: patch` to a commit message
* Creating a release branch (e.g. release/1.0) creates a brnach that has a bumped major version. Minor and Patch equal zero with an appendix of `rc.1+0+<number of commits>`  

![](./githubflow_feature-branch.png)

# Build and Run
* Build app using Version calculated by GitVersion 
```
dotnet build /property:Version=`gitversion /output json /showvariable SemVer`
```
* Run with `dotnet run --no-build`

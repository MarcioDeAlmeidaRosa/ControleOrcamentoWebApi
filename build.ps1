# restore and builds all projects as release.
# creates NuGet package at \artifacts
dotnet --version

# dotnet restore .\Contextos\
# dotnet pack .\Contextos\  --configuration release --include-symbols -o ..\..\artifacts

$versionPrefix = "2.1.0"
$versionSuffix = ""
$versionFile = $versionPrefix + "." + ${env:APPVEYOR_BUILD_NUMBER}
$versionProduct = $versionPrefix;
if (-Not $versionSuffix.Equals(""))
	{ $versionProduct = $versionProduct + "-" + $versionSuffix }

if ($env:APPVEYOR_PULL_REQUEST_NUMBER)
{
   $versionPrefix = $versionPrefix + "." + ${env:APPVEYOR_BUILD_NUMBER}
   $versionSuffix = "PR" + $env:APPVEYOR_PULL_REQUEST_NUMBER
}

# download nuget.exe

$sourceNugetExe = "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
$targetNugetExe = "tools\nuget.exe"
Invoke-WebRequest $sourceNugetExe -OutFile $targetNugetExe

Write-Output "###### -> msbuild Restore -> ControleOrcamento.Contexto.Domain.Teste"
msbuild /t:Restore,Pack .\Contextos\Testes\ControleOrcamento.Contexto.Domain.Teste\ /p:targetFrameworks='"netcoreapp2.1"' /p:VersionPrefix=$versionPrefix /p:VersionSuffix=$versionSuffix /p:FileVersion=$versionFile /p:ProductVersion=$versionProduct /p:Configuration=Release /p:IncludeSymbols=true /p:PackageOutputPath=..\..\artifacts /verbosity:minimal
if (-Not $LastExitCode -eq 0)
	{ exit $LastExitCode }

Write-Output "###### -> msbuild Restore -> ControleOrcamento.ContextoBancario.Domain.Teste"
msbuild /t:Restore,Pack .\Contextos\Testes\ControleOrcamento.ContextoBancario.Domain.Teste\ /p:targetFrameworks='"netcoreapp2.1"' /p:VersionPrefix=$versionPrefix /p:VersionSuffix=$versionSuffix /p:FileVersion=$versionFile /p:ProductVersion=$versionProduct /p:Configuration=Release /p:IncludeSymbols=true /p:PackageOutputPath=..\..\artifacts /verbosity:minimal
if (-Not $LastExitCode -eq 0)
	{ exit $LastExitCode }

Write-Output "###### -> msbuild Restore -> ControleOrcamento.ContextoQuitacao.Domain.Teste"
msbuild /t:Restore,Pack .\Contextos\Testes\ControleOrcamento.ContextoQuitacao.Domain.Teste\ /p:targetFrameworks='"netcoreapp2.1"' /p:VersionPrefix=$versionPrefix /p:VersionSuffix=$versionSuffix /p:FileVersion=$versionFile /p:ProductVersion=$versionProduct /p:Configuration=Release /p:IncludeSymbols=true /p:PackageOutputPath=..\..\artifacts /verbosity:minimal
if (-Not $LastExitCode -eq 0)
	{ exit $LastExitCode }
	
Write-Output "###### -> msbuild Restore -> ControleOrcamento.ContextoUsuario.Domain.Teste"
msbuild /t:Restore,Pack .\Contextos\Testes\ControleOrcamento.ContextoUsuario.Domain.Teste\ /p:targetFrameworks='"netcoreapp2.1"' /p:VersionPrefix=$versionPrefix /p:VersionSuffix=$versionSuffix /p:FileVersion=$versionFile /p:ProductVersion=$versionProduct /p:Configuration=Release /p:IncludeSymbols=true /p:PackageOutputPath=..\..\artifacts /verbosity:minimal
if (-Not $LastExitCode -eq 0)
	{ exit $LastExitCode }

Write-Output "###### -> msbuild Restore -> ControleOrcamento.Contexto.Domain"
msbuild /t:Restore,Pack .\Contextos\ControleOrcamento.Contexto.Domain\ /p:targetFrameworks='"netcoreapp2.1"' /p:VersionPrefix=$versionPrefix /p:VersionSuffix=$versionSuffix /p:FileVersion=$versionFile /p:ProductVersion=$versionProduct /p:Configuration=Release /p:IncludeSymbols=true /p:PackageOutputPath=..\..\artifacts /verbosity:minimal
if (-Not $LastExitCode -eq 0)
	{ exit $LastExitCode }

Write-Output "###### -> msbuild Restore -> ControleOrcamento.ContextoBancario.Domain"
msbuild /t:Restore,Pack .\Contextos\ControleOrcamento.ContextoBancario.Domain\ /p:targetFrameworks='"netcoreapp2.1"' /p:VersionPrefix=$versionPrefix /p:VersionSuffix=$versionSuffix /p:FileVersion=$versionFile /p:ProductVersion=$versionProduct /p:Configuration=Release /p:IncludeSymbols=true /p:PackageOutputPath=..\..\artifacts /verbosity:minimal
 if (-Not $LastExitCode -eq 0)
	{ exit $LastExitCode }
	
Write-Output "###### -> msbuild Restore -> ControleOrcamento.ContextoQuitacao.Domain"
msbuild /t:Restore,Pack .\Contextos\ControleOrcamento.ContextoQuitacao.Domain\ /p:targetFrameworks='"netcoreapp2.1"' /p:VersionPrefix=$versionPrefix /p:VersionSuffix=$versionSuffix /p:FileVersion=$versionFile /p:ProductVersion=$versionProduct /p:Configuration=Release /p:IncludeSymbols=true /p:PackageOutputPath=..\..\artifacts /verbosity:minimal
 if (-Not $LastExitCode -eq 0)
	{ exit $LastExitCode }

Write-Output "###### -> msbuild Restore -> ControleOrcamento.ContextoUsuario.Domain"
msbuild /t:Restore,Pack .\Contextos\ControleOrcamento.ContextoUsuario.Domain\ /p:targetFrameworks='"netcoreapp2.1"' /p:VersionPrefix=$versionPrefix /p:VersionSuffix=$versionSuffix /p:FileVersion=$versionFile /p:ProductVersion=$versionProduct /p:Configuration=Release /p:IncludeSymbols=true /p:PackageOutputPath=..\..\artifacts /verbosity:minimal
if (-Not $LastExitCode -eq 0)
	{ exit $LastExitCode }	

exit $LastExitCode

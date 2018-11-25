$projectFile = "ControleOrcamentoWebApi.sln"
$sonarQubeId = "MarcioDeAlmeidaRosa_ControleOrcamentoWebApi"
$sonarOrganization = "marciodealmeidarosa-github"
$github = "MarcioDeAlmeidaRosa/ControleOrcamentoWebApi"
$baseBranch = "master"
$framework = "netcoreapp2.1"
$sonar_token = "d1acfe8a3a3dbb679f3e36cf2c45b80cc06f2fc1"

if ($env:APPVEYOR_REPO_NAME -eq $github) {

    if (-not $sonar_token) {
        Write-warning "Sonar: not running SonarQube, no sonar_token"
        return;
    }
 
    $prMode = $false;
    $branchMode = $false;
     
    if ($env:APPVEYOR_PULL_REQUEST_NUMBER) { 
        # first check PR as that is on the base branch
        $prMode = $true;
        Write-Output "Sonar: on PR $env:APPVEYOR_PULL_REQUEST_NUMBER"
    }
    elseif ($env:APPVEYOR_REPO_BRANCH -eq $baseBranch) {
        Write-Output "Sonar: on base branch ($baseBranch)"
    }
    else {
        $branchMode = $true;
        Write-Output "Sonar: on branch $env:APPVEYOR_REPO_BRANCH"
    }

    choco install "msbuild-sonarqube-runner" -y

    $sonarUrl = "https://sonarcloud.io"
    $sonarToken = $sonar_token
    $buildVersion = $env:APPVEYOR_BUILD_VERSION

    if ($prMode) {
        $pr = $env:APPVEYOR_PULL_REQUEST_NUMBER
        Write-Output "Sonar: Running Sonar for PR $pr"
        SonarScanner.MSBuild.exe begin /k:"$sonarQubeId" /d:"sonar.host.url=$sonarUrl" /d:"sonar.login=$sonarToken" /v:"$buildVersion" /d:"sonar.analysis.mode=preview" /d:"sonar.github.pullRequest=$pr" /d:"sonar.github.repository=$github" /d:"sonar.github.oauth=$env:github_auth_token"
    }
    elseif ($branchMode) {
        $branch = $env:APPVEYOR_REPO_BRANCH;
        Write-Output "Sonar: Running Sonar in branch mode for branch $branch"
        SonarScanner.MSBuild.exe begin /k:"$sonarQubeId" /d:"sonar.host.url=$sonarUrl" /d:"sonar.login=$sonarToken" /v:"$buildVersion" /d:"sonar.branch.name=$branch"  
    }
    else {
        Write-Output "Sonar: Running Sonar in non-preview mode, on branch $env:APPVEYOR_REPO_BRANCH"
        SonarScanner.MSBuild.exe begin /k:"$sonarQubeId" /d:"sonar.organization=$sonarOrganization" /d:"sonar.host.url=$sonarUrl" /d:"sonar.cs.opencover.reportsPaths=&quot;opencover.xml&quot;" /d:"sonar.login=$sonarToken" /v:"$buildVersion"
    }

    Write-Output "Sonar: Running msbuild"
    msbuild /t:Rebuild $projectFile /p:targetFrameworks=$framework /verbosity:minimal

    Write-Output "Sonar: Running end"
    SonarScanner.MSBuild.exe end /d:"sonar.login=$sonarToken"
}
else {
    Write-Output "Sonar: not running as we're on '$env:APPVEYOR_REPO_NAME'"
}

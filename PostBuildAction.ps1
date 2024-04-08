# Parameter
$projectDir = $args[0]
Write-Host "projectDir: " $projectDir
$projectName = $args[1]
Write-Host "projectName: " $projectName
$targetDir = $args[2]
Write-Host "targetDir: " $targetDir
$targetName = $args[3]
Write-Host "targetName: " $targetName
# Zielordner
$ThemeDir = "wwwroot\Themes\"
$releaseName = "oqtane.framework-5.0.2"
$releaseProject = "Oqtane.Server"
$releaseProjectDir = $projectDir.Replace($projectName + "\", "") + $releaseName + "\" + $releaseProject
Write-Host "releaseProjectDir: " $releaseProjectDir
# Kopiervorgang
Copy-Item ($targetDir + $targetName + ".dll") -Destination ($releaseProjectDir + "\" + $targetDir.Replace($projectDir, ""))
Copy-Item ($targetDir + $targetName + ".pdb") -Destination ($releaseProjectDir + "\" + $targetDir.Replace($projectDir, ""))
Copy-Item ($projectDir + $ThemeDir + $projectName) -Force -Recurse -Destination ($releaseProjectDir + "\" + $ThemeDir)

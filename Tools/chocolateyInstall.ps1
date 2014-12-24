try {
  $installDir = (Split-Path -parent $MyInvocation.MyCommand.Definition)
  $exePath = Join-Path $installDir 'ShellTools.exe'
  
  Install-ChocolateyInstallPackage 'ShellTools' 'exe' '/Install' $exePath

  Write-ChocolateySuccess 'ShellTools'
} catch {
  Write-ChocolateyFailure 'ShellTools' $($_.Exception.Message)
  throw 
}
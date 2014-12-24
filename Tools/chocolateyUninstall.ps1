try {
  $installDir = (Split-Path -parent $MyInvocation.MyCommand.Definition)
  $exePath = Join-Path $installDir 'ShellTools.exe'
  
  Uninstall-ChocolateyInstallPackage 'ShellTools' 'exe' '/Uninstall' $exePath

  Write-ChocolateySuccess 'ShellTools'
} catch {
  Write-ChocolateyFailure 'ShellTools' $($_.Exception.Message)
  throw 
}
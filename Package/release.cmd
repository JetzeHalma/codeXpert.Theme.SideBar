del "*.nupkg"
"..\..\oqtane.framework\oqtane.package\nuget.exe" pack codeXpert.Theme.SideBar.nuspec 
XCOPY "*.nupkg" "..\..\oqtane.framework\Oqtane.Server\wwwroot\Packages\" /Y

# Runs every time a package is installed in a project

param($installPath, $toolsPath, $package, $project)

# $installPath is the path to the folder where the package is installed.
# $toolsPath is the path to the tools directory in the folder where the package is installed.
# $package is a reference to the package object.
# $project is a reference to the project the package was installed to.

# Removes dummy content text file which is used only to make this nuget package to work on project scope level.
$project.ProjectItems | where {$_.Name -eq "MSBuild.WebApplication.CopyContentLinkedFiles.Dummy.txt"} | ForEach-Object { $_.Remove() }

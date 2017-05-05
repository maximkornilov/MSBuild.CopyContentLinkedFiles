[![AppVeyor branch](https://img.shields.io/appveyor/ci/MaximKornilov/msbuild-copycontentlinkedfiles/master.svg?style=flat-square)](https://ci.appveyor.com/project/MaximKornilov/msbuild-copycontentlinkedfiles/branch/master)
[![NuGet](https://img.shields.io/nuget/v/MSBuild.WebApplication.CopyContentLinkedFiles.svg?style=flat-square)](https://www.nuget.org/packages/MSBuild.WebApplication.CopyContentLinkedFiles/)
[![NuGet](https://img.shields.io/nuget/dt/MSBuild.WebApplication.CopyContentLinkedFiles.svg?style=flat-square)](https://www.nuget.org/packages/MSBuild.WebApplication.CopyContentLinkedFiles/)

## MSBuild.WebApplication.CopyContentLinkedFiles
This repository contains sources of the NuGet package which adds MSBuild target to selected projects. This target copies all content files added as link to Web Application folder during build. 
More information about approach which is used can be found in the following answer for the following [StackOverflow question](http://stackoverflow.com/questions/13865534/visual-studio-add-as-link-not-working-while-debugging/13868281#13868281).

#### Download: 
Package can be downloaded via NuGet. For instructions see the following [page](https://www.nuget.org/packages/MSBuild.WebApplication.CopyContentLinkedFiles/).

#### Note
If you use source control then it is better to add copied files (from Web Application folder) to ignore list.
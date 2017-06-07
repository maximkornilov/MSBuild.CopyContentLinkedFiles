// Target - The task you want to start. Runs the Default task if not specified.
var target = Argument("Target", "Default");
    
// A directory path to an Artifacts directory.
var artifactsDirectory = Directory("./artifacts");
// Deletes the contents of the Artifacts folder if it should contain anything from a previous build.
Task("Clean")
    .Does(() =>
    {
        CleanDirectory(artifactsDirectory);
    });

Task("Pack")
    .IsDependentOn("Clean")
    .Does(() =>
    {
        var basePath = "./src/MSBuild.CopyContentLinkedFiles";
        NuGetPack(
            System.IO.Path.Combine(basePath, "MSBuild.CopyContentLinkedFiles.nuspec"),
            new NuGetPackSettings 
            {
                BasePath = basePath,
                OutputDirectory = artifactsDirectory,
            });
    });

// The default task to run if none is explicitly specified. In this case, we want
// to run everything starting from Clean, all the way up to Pack.
Task("Default")
    .IsDependentOn("Pack");

// Executes the task specified in the target argument.
RunTarget(target);
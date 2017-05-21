var target = Argument("target", "Default");

Task("Unit")
  .Does(() =>
{
  Information("Running Unit tests");
  //throw new Exception(String.Format("Release notes are missing"));
});

Task("Integration")
  .Does(() =>
{
  Information("Running Integration tests");
  //throw new Exception(String.Format("Release notes are missing"));
});

Task("Default")
    .IsDependentOn("Unit")
    .IsDependentOn("Integration");

RunTarget(target);
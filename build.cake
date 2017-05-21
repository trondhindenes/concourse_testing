var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  Information("Hello World from Concourse");
  //throw new Exception(String.Format("Release notes are missing"));
});

RunTarget(target);
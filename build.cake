var target = Argument("target", "Default");

Task("Default")
  .Does(() =>
{
  Information("Hello World from Concourse");
});

RunTarget(target);
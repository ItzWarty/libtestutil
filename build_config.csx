var projects = Projects("nmockito");

Export.Solution(
   Name: "NMockito",
   Commands: new ICommand[] {
      Build.Projects(projects),
      Test.Projects(projects)
   }
);
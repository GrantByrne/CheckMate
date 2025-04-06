using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<CheckMate_Web>("Web");

builder.Build().Run();

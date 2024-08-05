using Projects;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<WebApp>("web-app");

builder.Build().Run();

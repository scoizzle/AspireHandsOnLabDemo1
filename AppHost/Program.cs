using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var db = builder.AddPostgres("db");

var be = builder.AddProject<FlakeyWebApp>("flakey-web-app");

builder.AddProject<WebApp>("web-app")
    .WithReference(db)
    .WithReference(be);

builder.Build().Run();

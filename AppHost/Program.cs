using Projects;

var builder = DistributedApplication.CreateBuilder(args);

var db = builder.AddPostgres("db");

builder.AddProject<WebApp>("web-app")
    .WithReference(db);

builder.Build().Run();

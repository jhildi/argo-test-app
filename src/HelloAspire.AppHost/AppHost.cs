var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.HelloAspire_ApiService>("apiservice");

builder.Build().Run();

var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MauiNav4>("mauinav4");

builder.Build().Run();

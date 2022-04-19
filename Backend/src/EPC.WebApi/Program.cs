using EPC.Data;
using EPC.Services;
using EPC.Services.DocumentServices;
using EPC.Services.UserServices;
using EPC.WebApi.GraphQLServer.Queries;
using GraphQL.Server.Ui.Voyager;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("EncryptedPocketCertificateConnection");
// Add services to the container.
builder.Services.AddPooledDbContextFactory<AppDbContext>(options =>
    options.UseNpgsql(connectionString!));

builder.Services.AddTransient<ServiceManager>();

builder.Services.AddScoped<AppDbContext>();

// Graphql Services
builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<AppDbContext>(DbContextKind.Pooled)
    .AddQueryType(q => q.Name("Query"))
    .RegisterService<ServiceManager>()
    .AddTypeExtension<UserQueries>()
    .AddTypeExtension<DocumentQueries>();


var app = builder.Build();

app.MapGraphQL();
app.MapGraphQL("/admin/graphql", schemaName: "adminSchema");

app.UseGraphQLVoyager(new VoyagerOptions()
{
    GraphQLEndPoint = "/graphql",
}, "/graphql-voyager");

SeedData.EnsurePopulated(app);

app.Run();

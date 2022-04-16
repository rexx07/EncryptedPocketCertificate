using EPC.Data;
using EPC.Data.Contracts;
using EPC.Data.Repository;
using EPC.WebApi.GraphQLServer.Queries;
using GraphQL.Server.Ui.Voyager;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("EncryptedPocketCertificateConnection");
// Add services to the container.
builder.Services.AddPooledDbContextFactory<AppDbContext>(options =>
    options.UseNpgsql(connectionString!));

// Register an additional context factory as a Scoped service, which gets a pooled context from the Singleton
// factory we registered above,
builder.Services.AddScoped<IRepositoryManager, RepositoryManager>();

//builder.Services.AddTransient<RepositoryManager>();

// Graphql Services
builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<AppDbContext>(DbContextKind.Pooled)
    //.RegisterService<RepositoryManager>()
    .AddQueryType(q => q.Name("Query"))
    .AddTypeExtension<UserQueries>()
    .AddTypeExtension<DocumentQueries>();



var app = builder.Build();

app.MapGraphQL();
app.MapGraphQL("/admin/graphql", schemaName: "adminSchema");

app.UseGraphQLVoyager(new VoyagerOptions()
{
    GraphQLEndPoint = "/graphql",
}, "/graphql-voyager");

Task task = SeedData.EnsurePopulated(app);

app.Run();

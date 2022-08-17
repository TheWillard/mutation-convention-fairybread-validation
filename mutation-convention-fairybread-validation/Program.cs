using FluentValidation.AspNetCore;
using mutation_convention_fairybread_validation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining(typeof(Program)));

builder.Services
    .AddGraphQLServer()
    .AddFairyBread()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddMutationConventions(
        new MutationConventionOptions
        {
            //InputArgumentName = "input",
            //InputTypeNamePattern = "{MutationName}Input",
            PayloadTypeNamePattern = "{MutationName}Payload",
            PayloadErrorTypeNamePattern = "{MutationName}Error",
            PayloadErrorsFieldName = "errors",
            ApplyToAllMutations = false
        }
    );

var app = builder.Build();

app.MapGraphQL();
app.MapGet("/", () => "Hello World!");

app.Run();

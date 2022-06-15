using Amazon.Lambda.Core;
using Amazon.Lambda.RuntimeSupport;
using Amazon.Lambda.Serialization.SystemTextJson;
using CSLamdbaTest.Models;
using CSLamdbaTest;

// The function handler that will be called for each Lambda event
var handler = (LambdaInput input, ILambdaContext context) =>
{
    DataManager dataManager = new();

    Bio created = dataManager.AddBio(input.name);

    dataManager.SaveChanges();

    return created;
};

// Build the Lambda runtime client passing in the handler to call for each
// event and the JSON serializer to use for translating Lambda JSON documents
// to .NET types.
await LambdaBootstrapBuilder.Create(handler, new DefaultLambdaJsonSerializer())
        .Build()
        .RunAsync();
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

const string configFolderEnvVarName = "CONFIG_COLLECTION_FOLDER";

var configFolderPath = Environment.GetEnvironmentVariable(configFolderEnvVarName) ?? "configs";

if (!Directory.Exists(configFolderPath)) throw new ApplicationException($"path '{configFolderPath}' to the configs folder provided with env variable {configFolderEnvVarName} is not exists");

app.MapGet("/config-file/{file}",
    ([FromRoute] string file) =>
        ConfigFileNotExists(file)
            ? Results.NotFound()
            : Results.Stream(File.OpenRead(GetFilePath(file)), fileDownloadName: file));

app.MapGet("/config-json/{file}",
    async ([FromRoute] string file, CancellationToken token) =>
    {
        if (ConfigFileNotExists(file)) return Results.NotFound();
        
        await using var readStream = File.OpenRead(GetFilePath(file));
        var result = await JsonSerializer.DeserializeAsync<object>(readStream, options:null, token);
        return Results.Json(result);
    });

app.Run();

bool ConfigFileNotExists(string file) => !File.Exists(Path.Combine(configFolderPath, file));
string GetFilePath(string file) => Path.Combine(configFolderPath, file);


using Cocona;
using Microsoft.Extensions.DependencyInjection;
using Roadmap.GithubActivity.User;

var builder = CoconaApp.CreateBuilder();

builder.Services.AddSingleton<IUserRepository, UserRepository>();

var app = builder.Build();

app.AddCommand("username", ([Argument] string name, IUserRepository repo) =>
{
});

app.Run();
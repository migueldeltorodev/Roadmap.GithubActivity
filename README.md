# Roadmap.GithubActivity

This is a simple CLI (Command Line Interface) application to fetch the recent activity of a GitHub user and display it in the terminal. The project include working with the GitHub API, handling JSON data.
## Requirements

The application should run from the command line, accept the GitHub username as an argument, fetch the user’s recent activity using the GitHub API, and display it in the terminal. The user should be able to:

- Provide the GitHub username as an argument when running the CLI.
    
    ```
    dotnet run -- activity <username>
    ```

This is an output example of what you'll get:

```
Output:
- PushEvent: username/repo  
- CreateEvent: username/repo  
- WatchEvent: username/repo
```

## Technical Requirements

Before you run the app you need to install the nexts nuget packages:

`Cocona` `Microsoft.Extensions.DependencyInjection` `Microsoft.Extensions.Http` `System.Net.Http` `System.Text.Json`

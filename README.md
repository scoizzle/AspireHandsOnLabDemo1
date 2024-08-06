Created while attending the VSLive@MSFTHQ 2024 .NET Aspire Hands on Lab by David Fowler and Damien Edwards

# Running this demo

## Requirements

1. .NET 8.0 SDK
   - Download and install from [here](https://dotnet.microsoft.com/en-us/download) or via Win-Get `winget install Microsoft.DotNet.SDK.8`
2. Aspire 8.1
   - Once the NET 8.0 SDK is installed open a terminal and run `dotnet workload install aspire`
3. Docker Desktop / Podman
   - Download and install from [here](https://www.docker.com/products/docker-desktop/)

## Executing

Starting this app is as simple as running this command from with the AppHost directory within this repo

    dotnet run

The app will then write a url to your terminal where you may access the app's real time dashboard

If you encounter an message stating `Container runtime 'docker' was found but appears to be unhealthy` it is likely that the docker or podman service is not running.

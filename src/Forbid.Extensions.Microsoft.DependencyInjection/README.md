# Forbid.Extensions.Microsoft.DependencyInjection

Package to support Microsoft Dependency Injection for [Forbid](https://www.nuget.org/packages/Forbid/) package.

## Usage

Startup.cs
```c#
using Forbids;

public void ConfigureServices(IServiceCollection services)
{
    services.AddForbids();  
}

Or

using Forbids;

public void ConfigureServices(IServiceCollection services)
{
    services.AddForbids(ServiceLifetime.Scoped); //default is Singleton  
}
```
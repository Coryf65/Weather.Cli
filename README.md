# Weather.Cli

- Learning how to Build a CLI tool using C# and .NET with [Open Weather API](https://openweathermap.org/current).

We can submit a city name and get the current weather!

This free service does have call limits..

Free Plan
- Hourly forecast: unavailable
- Daily forecast: unavailable
- Calls per minute: 60
- 3 hour forecast: 5 days 

## Setup to run yourself

1. Go to Open Weather and sign up for a free account

2. Create an API key

3. Create a [User Secret](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows) and add your key into the file.

> NOTE: replace *"API_KEY"* with **your api key** from OpenWeather

```json
{
	"apiKey": "API_KEY"
}
```

4. Run the app 

	a. You can run as a console app in Visual Studio
	b. You can run in the cli
	
		- Open a terminal at the projects root path and run

		```cli
		dotnet pack
		```

		This will build our app to run as a cli tool

		Next we run the following

		```cli
		dotnet tool install --global --add-source ./nupkg weather.cli
		```

		should get a success message

		now we can run it in a terminal with ...

		```cli
		weather Chicago
		```



## How To convert a Console App into a CLI tool

add the following to the CSProj file. 

> In Visual Studio, Right click csproj and click 'Edit Project File'

```xml
<!-- Additions to run as a CLI tool -->
<PackAsTool>true</PackAsTool>
<!--Name of how to invoke the cli tool-->
<ToolCommandName>weather</ToolCommandName>
<PackageOutputPath>./nupkg</PackageOutputPath>
```
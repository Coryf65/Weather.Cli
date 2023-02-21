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

![image](https://user-images.githubusercontent.com/20805058/220462508-9fa996a7-b9f5-4c7c-bbea-3886acf229ac.png)

b. You can run in the cli

- Open a terminal at the projects root path and run

![image](https://user-images.githubusercontent.com/20805058/220462593-b1d8cb1d-4412-4c0b-8d90-24f9144e3441.png)

```cli
dotnet pack
```

![image](https://user-images.githubusercontent.com/20805058/220462667-2c328fb5-a626-4fb7-a7f9-87e26bc04f93.png)

This will build our app to run as a cli tool

Next we run the following

```cli
dotnet tool install --global --add-source ./nupkg weather.cli
```

![image](https://user-images.githubusercontent.com/20805058/220462758-d483f9b6-5053-4384-a5ae-44e80acfdddb.png)

should get a success message

now we can run it in a terminal with ...

```cli
weather Chicago
```

![image](https://user-images.githubusercontent.com/20805058/220462821-649431de-7dbd-4927-9fdd-56cf0316b8dc.png)


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

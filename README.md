# Weather.Cli

- Learning how to Build a CLI tool using C# and .NET with [Open Weather API](https://openweathermap.org/current).

We can submit a city name and get the current weather!

This free service does have call limits..

Free Plan
- Hourly forecast: unavailable
- Daily forecast: unavailable
- Calls per minute: 60
- 3 hour forecast: 5 days 

## Setup

- Create a [User Secret](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-6.0&tabs=windows) with the following info...

> NOTE: replace *"API_KEY"* with **your api key** from OpenWeather

```json
{
	"apiKey": "API_KEY"
}
```
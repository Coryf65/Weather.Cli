// Open Weather API CLI tool

using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Http.Json;
using Weather.Cli.Models;

var config = new ConfigurationBuilder().AddUserSecrets<WeatherSettings>().Build();
string apiKey = config["apiKey"]; // getting from User Secrets
const string url = "https://api.openweathermap.org/";

var httpClient = new HttpClient
{
	BaseAddress = new Uri(url)
};

var city = args.AsQueryable().FirstOrDefault();

Start:
if(city == null)
{
	Console.WriteLine("City Name: ");
	city = Console.ReadLine()!.Trim();
}

var response = await httpClient.GetAsync($"data/2.5/weather?q={city}&appid={apiKey}&units=imperial");

if(response.StatusCode == HttpStatusCode.NotFound)
{
	Console.WriteLine($"Weather not found for city: '{city}'");
	goto Start;
}

var currentWeather = await response.Content.ReadFromJsonAsync<WeatherResponse>();

Console.WriteLine($"Current weather in {city}");
Console.WriteLine($"City: {currentWeather!.Name}");
Console.WriteLine($"Country: {currentWeather.Sys.Country}");
Console.WriteLine($"Weather: {currentWeather.Weather[0].Description}");
Console.WriteLine($"Temperature: {currentWeather.Main.Temp}°F");
Console.WriteLine($"Humidity: {currentWeather.Main.Humidity}%");
Console.WriteLine($"Pressure: {currentWeather.Main.Pressure}hPa");
Console.WriteLine($"Wind: {currentWeather.Wind.Speed}m/s, {currentWeather.Wind.Deg}°");
Console.WriteLine($"Clouds: {currentWeather.Clouds.All}%");
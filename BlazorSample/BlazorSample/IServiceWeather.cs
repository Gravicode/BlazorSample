using Microsoft.AspNetCore.Blazor;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorSample
{
    public interface IServiceWeather
    {
        Task<List<WeatherData>> GetData();
    }

    public class WeatherData
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }

    public class ServiceWeather : IServiceWeather
    {
        HttpClient client;
        public ServiceWeather(HttpClient client)
        {
            this.client = client;
        }
        public async Task<List<WeatherData>> GetData()
        {
            List< WeatherData> forecasts;
  
            forecasts = await client.GetJsonAsync<List<WeatherData>>("/sample-data/weather.json");
          
            return forecasts;
        }
    
    }
}

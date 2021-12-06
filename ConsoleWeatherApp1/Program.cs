using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Weather.ApiWrapper;

namespace ConsoleWeatherApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var weatherWrapper = new WeatherApi();
            
            var result = await weatherWrapper.GetResult();

            var parsed  = JToken.Parse(result);
            
            Console.WriteLine(parsed.ToString(Formatting.Indented));
        }
    }
}

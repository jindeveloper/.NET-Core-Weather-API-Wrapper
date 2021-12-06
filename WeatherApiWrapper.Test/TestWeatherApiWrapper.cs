using Xunit;

namespace WeatherApiWrapper.Test
{
    public class TestWeatherApiWrapper
    {
        [Fact]
        public async void TestWeatherApiWrapper_GetResult()
        {
            var weatherWrapper = new Weather.ApiWrapper.WeatherApi();
            var result = await weatherWrapper.GetResult();
        }
    }
}

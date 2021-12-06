using Weather.ApiWrapper.Config;
using Xunit;

namespace WeatherApiWrapper.Test
{
    public class TestWeatherSettings
    {
        [Fact]
        public void TestWeatherSettings_Get_URL()
        {
           Assert.NotNull(WeatherSettings.Get("URL")); 
           Assert.NotEqual("",WeatherSettings.Get("URL"));
        }

        [Fact]
        public void TestWeatherSettings_Get_APIKey()
        {
            Assert.NotNull(WeatherSettings.Get("APIKey"));
            Assert.NotEqual("", WeatherSettings.Get("APIKey"));
        }

        [Fact]
        public void TestWeatherSettings_Get_Units()
        {
            Assert.NotNull(WeatherSettings.Get("Units"));
            Assert.NotEqual("", WeatherSettings.Get("Units"));
        }


        [Fact]
        public void TestWeatherSettings_Get_Latitude()
        {
            Assert.NotNull(WeatherSettings.Get("Latitude"));
            Assert.NotEqual("", WeatherSettings.Get("Latitude"));
        }

        [Fact]
        public void TestWeatherSettings_Get_Longitude()
        {
            Assert.NotNull(WeatherSettings.Get("Longitude"));
            Assert.NotEqual("", WeatherSettings.Get("Longitude"));
        }

        [Fact]
        public void TestWeatherSettings_Get_Fields()
        {
            Assert.NotNull(WeatherSettings.Get("Fields", isArray:true));
            Assert.NotEqual("", WeatherSettings.Get("Fields", isArray: true));
        }
    }
}

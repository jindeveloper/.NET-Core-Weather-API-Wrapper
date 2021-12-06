using System;
using Weather.ApiWrapper.Concrete;
using Weather.ApiWrapper.Interface;
using Xunit;

namespace WeatherApiWrapper.Test
{
    public class TestWeatherParameter
    {
        private readonly IWeatherParameters _parameter = null;

        public TestWeatherParameter()
        {
            _parameter = new WeatherParameter();
        }

        [Fact]
        public void TestWeatherParameter_Fields()
        {
            var fields = _parameter.Fields;

            Assert.Contains(",", fields);
        }

        [Fact]
        public void TestWeatherParameter_URI_Generation()
        {
            var uriResult = _parameter.GetUri();
            
            Assert.True(Uri.IsWellFormedUriString(uriResult.ToString(), UriKind.RelativeOrAbsolute));
        }
    }
}

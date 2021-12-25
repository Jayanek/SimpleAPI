using System;
using Xunit;
using  SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {

        }
       
        WeatherForecastController wc = new WeatherForecastController();

        [Fact]
        public void Get_WeatherByID()
        {
         var expect = "Kamal hasan";

         var actual = wc.Get(1);

         Assert.Equal(expect,actual.Value);
        
        }

        
    }
}

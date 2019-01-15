using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using log4net;
using log4net.Config;
namespace RoomAutomationSystem
{
    [TestFixture]
    public class TestCases
    {
        [Test]
        public void TestTemperature()
        {
            RoomAutomationSystem ras = new RoomAutomationSystem();
            Temperature temperature=ras.GetTemperatureFrequency();
             DateTime date = temperature.Date;
             Decimal temperature_freq = temperature.Frequency;
             Assert.IsTrue(temperature_freq>=0 && temperature_freq<=60 );
             Assert.IsTrue(date <= DateTime.Now);
        }
        [Test]
        public void TestPressure()
        {
            RoomAutomationSystem ras = new RoomAutomationSystem();
            Pressure pressure = ras.GetPressureFrequency();
            DateTime date = pressure.Date;
            Decimal pressure_freq = pressure.Frequency;
            Assert.IsTrue(pressure_freq >= 0 && pressure_freq <= 1000);
            Assert.IsTrue(date <= DateTime.Now);
        }
        [Test]
        public void TestHumidity()
        {
            RoomAutomationSystem ras = new RoomAutomationSystem();
            Humidity humidity = ras.GetHumidityFrequency();
            DateTime date = humidity.Date;
            Decimal humidity_freq = humidity.Frequency;
            Assert.IsTrue(humidity_freq >= 0 && humidity_freq <= 100);
            Assert.IsTrue(date <= DateTime.Now);
        }
        [Test]
        public void TestLux()
        {
            RoomAutomationSystem ras = new RoomAutomationSystem();
            Lux lux = ras.GetLuxFrequency();
            DateTime date = lux.Date;
            Decimal Lux_freq = lux.Frequency;
            Assert.IsTrue(Lux_freq >= 100 && Lux_freq <= 2000);
            Assert.IsTrue(date <= DateTime.Now);
        }
    }
}
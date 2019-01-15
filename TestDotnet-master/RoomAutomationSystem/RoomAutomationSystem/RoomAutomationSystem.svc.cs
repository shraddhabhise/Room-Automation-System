using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using RoomAutomationSystem;
using System.ServiceModel.Web;
using Cassandra;
using log4net;


namespace RoomAutomationSystem
{
    public class RoomAutomationSystem : IRoomAutomationSystem
    {
        [WebGet(UriTemplate = "Temperature")]
        public Temperature GetTemperatureFrequency()
        {
            
             
                double minValue = 0.0;
                double maxValue = 60.0;
                decimal temp = (decimal)RandomGenerator.Temperaturefreq(minValue, maxValue);
                DateTime date1 = DateTime.Now;
                return new Temperature
                {
                    Frequency = temp,
                    Date = date1,

                };
                 
        }
        [WebGet(UriTemplate = "Pressure")]
        public Pressure GetPressureFrequency()
        {
            double minValue = 0.0;
            double maxValue = 1000.0;
            decimal press = (decimal)RandomGenerator.Pressurefreq(minValue, maxValue);
            DateTime date1 = DateTime.Now;
            return new Pressure
            {
                Frequency = press,
                Date = date1,

            };
        }
        [WebGet(UriTemplate = "Humidity")]
        public Humidity GetHumidityFrequency()
        {
            double minValue = 1.0;
            double maxValue = 100.0;
            decimal humid = (decimal)RandomGenerator.Humidityfreq(minValue, maxValue);
            DateTime date1 = DateTime.Now;
            return new Humidity
            {
                Frequency = humid,
                Date = date1,

            };
        }
        [WebGet(UriTemplate = "Lux")]
        public Lux GetLuxFrequency()
        {
            double minValue = 100.0;
            double maxValue = 2000.0;
            decimal lux = (decimal)RandomGenerator.Luxfreq(minValue, maxValue);
            DateTime date1 = DateTime.Now;
            
            return new Lux
            {
                Frequency = lux,
                Date = date1,

            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoomAutomationSystem
{


   public static class RandomGenerator
    {
        private static readonly Random _random = new Random();
        public static double Temperaturefreq(double minValue, double maxValue)
        {
            var next = _random.NextDouble();
            return minValue + (next * (maxValue - minValue));
        }
        public static double Pressurefreq(double minValue, double maxValue)
        {
            var next = _random.NextDouble();
            return minValue + (next * (maxValue - minValue));
        }
        public static double Luxfreq(double minValue, double maxValue)
        {
            var next = _random.NextDouble();
            return minValue + (next * (maxValue - minValue));
        }
        public static double Humidityfreq(double minValue, double maxValue)
        {
            var next = _random.NextDouble();
            return minValue + (next * (maxValue - minValue));
        }
    }
}

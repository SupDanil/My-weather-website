using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask.Models
{
    public class WeatherResponse
    {
       public TemperatureInfo Main { get; set; }
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TemperatureMonitoring_2_0
{
    public abstract class Quality
    {

    }

    public class TempQuality : Quality
    {
        Dictionary<DateTime, double> temperature;

        public TempQuality()
        {
            temperature = new Dictionary<DateTime, double>();
        }

        public TempQuality(Dictionary<DateTime, double> temp)
        {
            this.temperature = temp;
        }
        public TempQuality(DateTime begin, TimeSpan interval, double[] data)
        {
            //Доделать
        }

        public TempQuality(int timeInterval, string temperatureData) : this()
        {

            var time = DateTime.Now;
            var interval = new TimeSpan(0, timeInterval, 0);
            foreach (var t in temperatureData.Split())
            {
                temperature.Add(time, Double.Parse(t));
                time += interval;
            }

        }

        public double GetMaxTemp()
        {
            return 10.1;
        }

        public double GetMinTemp()
        {
            return 1.1;
        }

        public TimeSpan GetTempUpperTime(double temp)
        {
            return new TimeSpan();
        }

        public TimeSpan GetTempLowerTime(double temp)
        {
            return new TimeSpan();
        }
    }
}

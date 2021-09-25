using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureMonitoring_2_0
{
    public abstract class Quality
    {

    }

    public class TempQuality : Quality
    {
        //Dictionary<DateTime, double> temperature;
        TimeSpan interval;

        public TempQuality(Dictionary<DateTime, double> temp)
        {
            //this.temperature = temp;
        }
        public TempQuality(DateTime begin, TimeSpan interval, double[] data)
        {
            this.interval = interval;
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

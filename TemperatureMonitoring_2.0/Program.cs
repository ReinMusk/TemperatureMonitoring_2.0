using System;
using System.Collections.Generic;

namespace TemperatureMonitoring_2_0
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime begin = DateTime.Now;
            TimeSpan interval = new TimeSpan(0, 5, 0);
            double[] data = {1, 2, 3, 3, 4, 3, 5, 4, 2, 1, 1.1, 1, 1, 0, -1.1, -2, -2, -3, -4, -4, -5.7, -5, -4, -4, -4, -3};
            TempQuality quality = new TempQuality(begin, interval, data);

            double mx = 5.0;

            TimeSpan deathTime = new TimeSpan(0,20,0);


            Fish mentai = new FrozenFish(quality, mx, deathTime);
            mentai.isValid();
        }
    }
}
using System;
using System.Collections.Generic;

namespace FishMonitoringConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Quality quality = new TempQuality();
            Fish mentai = new FrozenFish(quality, mx, deathTime);
            mentai.isValid();
        }
    }

    public abstract class Fish
    {
        public string name;
        public Quality quality;
        public abstract bool isValid();
    }

    public class FrozenFish : Fish
    {
        public double maxStoreTemp;
        public TimeSpan deathTime;

        public override bool isValid()
        {
            return !((quality as TempQuality).GetTempUpperTime(maxStoreTemp) > deathTime);
        }
    }
    public class ChilledFish : Fish
    {
        public double minStoreTemp;
        public double maxStoreTemp;
        public TimeSpan minDeathTime;
        public TimeSpan maxDeathTime;

        public override bool isValid()
        {
            return !((quality as TempQuality).GetTempUpperTime(maxStoreTemp) > maxDeathTime
                || (quality as TempQuality).GetTempLowerTime(maxStoreTemp) < minDeathTime);
        }
    }

    public abstract class Quality
    {

    }

    public class TempQuality : Quality
    {
        Dictionary<DateTime, double> temperature;


        public TempQuality(Dictionary<DateTime, double> temp)
        {
            this.temperature = temp;
        }
        public TempQuality(DateTime begin, TimeSpan interval, double[] data)
        {
            //Доделать
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
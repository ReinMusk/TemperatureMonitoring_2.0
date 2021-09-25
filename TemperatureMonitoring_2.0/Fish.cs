using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureMonitoring_2_0
{
    public abstract class Fish
    {
        public string name;
        public TempQuality quality;
        public abstract bool isValid();

        public Fish()
        { 
            
        }
    }
    
    public class FrozenFish : Fish
    {
        public double maxStoreTemp;
        public TimeSpan deathTime;

        public override bool isValid()
        {
            return !((quality as TempQuality).GetTempUpperTime(maxStoreTemp) > deathTime);
        }
        public FrozenFish(Quality qual, double mxt, TimeSpan deathTime)
        {
            this.maxStoreTemp = mxt;
            this.deathTime = deathTime;
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
}

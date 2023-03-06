using AM.Core.Domain;
using System.Runtime.CompilerServices;

namespace AM.Core.Extensions
{
    public static class FlightExtension
    {
        public   static double GetDelay(this Flight f)
        {
             return  (f.EffectiveArrival - f.FlightDate).TotalMinutes - f.estimationDuration;
        }
    }
}
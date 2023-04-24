using AM.Core.Domain;

namespace AM.Core.Extensions
{
    public static class FlightExtensions
    { 
        public static double GetDelay(this Flight f) //static *2 
        {
            return (f.EffectiveArrival - f.FlightDate) // duree reelle
                .TotalMinutes - f.EstimatedDuration;    //
        }
    }
}
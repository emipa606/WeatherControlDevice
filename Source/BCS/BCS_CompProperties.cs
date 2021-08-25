using Verse;

namespace BCS
{
    internal class BCS_CompProperties : CompProperties
    {
        public string BCS_WeatherType = "Clear";

        public BCS_CompProperties()
        {
            compClass = typeof(BCS_CompWeatherMachine);
        }
    }
}
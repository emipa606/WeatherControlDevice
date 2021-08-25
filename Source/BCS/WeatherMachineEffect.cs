using RimWorld;
using Verse;

namespace BCS
{
    public class WeatherMachineEffect : CompUseEffect
    {
        public override void DoEffect(Pawn usedBy)
        {
            var weatherType = usedBy.CurJobDef.defName.Replace("BCS_JobDefs", "");
            foreach (var item in Find.CurrentMap.listerBuildings.AllBuildingsColonistOfClass<BCS_WeatherMachine>())
            {
                var weatherMachine = item.GetComp<BCS_CompWeatherMachine>();
                if (weatherMachine is { props: BCS_CompProperties weatherMachineProperties })
                {
                    weatherMachineProperties.BCS_WeatherType = weatherType;
                }
            }
        }
    }
}
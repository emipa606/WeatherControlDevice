using RimWorld;
using Verse;

namespace BCS;

[StaticConstructorOnStartup]
public class BCS_WeatherMachine : Building
{
    private CompPowerTrader power;

    public override void SpawnSetup(Map map, bool respawningAfterLoad)
    {
        base.SpawnSetup(map, respawningAfterLoad);
        power = GetComp<CompPowerTrader>();
    }

    protected override void Tick()
    {
        if (Find.TickManager.TicksGame % 2500 != 0 || power is not { PowerOn: true })
        {
            return;
        }

        var comp = GetComp<BCS_CompWeatherMachine>();
        if (comp.props is not BCS_CompProperties properties)
        {
            return;
        }

        var bCsWeatherType = properties.BCS_WeatherType;
        var weatherManager = Find.CurrentMap.weatherManager;

        if (weatherManager.curWeather != WeatherDef.Named(bCsWeatherType))
        {
            weatherManager.TransitionTo(WeatherDef.Named(bCsWeatherType));
        }

        var weatherAgeTarget = weatherManager.curWeather.durationRange.min / 2;

        if (weatherManager.curWeatherAge >= weatherAgeTarget &&
            weatherManager.curWeather == WeatherDef.Named(bCsWeatherType))
        {
            weatherManager.curWeatherAge = weatherAgeTarget;
        }
    }
}
using RimWorld;
using Verse;

namespace BCS;

[StaticConstructorOnStartup]
public class BCS_WeatherMachine : Building
{
    private CompPowerTrader _Power;

    public override void SpawnSetup(Map map, bool respawningAfterLoad)
    {
        base.SpawnSetup(map, respawningAfterLoad);
        _Power = GetComp<CompPowerTrader>();
    }

    public override void Tick()
    {
        if (Find.TickManager.TicksGame % 2500 != 0 || _Power == null || !_Power.PowerOn)
        {
            return;
        }

        var comp = GetComp<BCS_CompWeatherMachine>();
        if (comp.props is not BCS_CompProperties properties)
        {
            return;
        }

        var bCS_WeatherType = properties.BCS_WeatherType;
        var weatherManager = Find.CurrentMap.weatherManager;

        if (weatherManager.curWeather != WeatherDef.Named(bCS_WeatherType))
        {
            weatherManager.TransitionTo(WeatherDef.Named(bCS_WeatherType));
        }

        var weatherAgeTarget = weatherManager.curWeather.durationRange.min / 2;

        if (weatherManager.curWeatherAge >= weatherAgeTarget &&
            weatherManager.curWeather == WeatherDef.Named(bCS_WeatherType))
        {
            weatherManager.curWeatherAge = weatherAgeTarget;
        }
    }
}
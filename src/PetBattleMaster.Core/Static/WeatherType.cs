namespace PetBattleMaster.Core.Static
{
    /// <summary>
    /// Represents a weather on a battlefield.
    /// </summary>
    /// <remarks>
    /// A weather can affect pet stats and some abilities.
    /// </remarks>
    public enum WeatherType : byte
    {
        Unknown = 0,
        None,
        CleansingRain,
        ArcaneWinds,
        Blizzard,
        Darkness,
        LightningStorm,
        SunnyDay,
        MoonLight,
        Muddy,
        SandStorm,
        ScorchedEarth
    }
}
namespace PetBattleMaster.Core.Static
{
    /// <summary>
    /// Described pet breed.
    /// </summary>
    /// <remarks>
    /// Pet breed determines power, speed and health points distribution.
    /// </remarks>
    public enum PetBreed : byte
    {
        Unknown = 0,
        Power,
        Speed,
        Health,
        PowerBalance,
        SpeedBalance,
        HealthBalance,
        Balance
    }
}

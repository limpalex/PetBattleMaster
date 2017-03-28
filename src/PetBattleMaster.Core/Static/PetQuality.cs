namespace PetBattleMaster.Core.Static
{
    /// <summary>
    /// Describes pet quality.
    /// </summary>
    /// <remarks>
    /// Pet quality determines additional multiplier for pet parameters.
    /// </remarks>
    public enum PetQuality : byte
    {
        Unknown,
        Poor,
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }
}
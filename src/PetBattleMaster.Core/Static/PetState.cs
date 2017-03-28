namespace PetBattleMaster.Core.Static
{
    /// <summary>
    /// Represents a specific pet state.
    /// </summary>
    /// <remarks>
    /// Pet state has its own effect and it can affect some abilities.
    /// </remarks>
    public enum PetState : byte
    {
        Unknown = 0,
        Stunned,
        Bleeding,
        Webbed,
        Blinded,
        Poisoned,
        Burning,
        Chilled
    }
}
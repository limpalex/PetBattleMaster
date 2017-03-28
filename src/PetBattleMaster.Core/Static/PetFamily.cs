namespace PetBattleMaster.Core.Static
{
    /// <summary>
    /// Describes pet family.
    /// </summary>
    /// <remarks>
    /// Pet family determines toughness and weakness against specific abilities as well as special family perks.
    /// </remarks>
    public enum PetFamily : byte
    {
        Unknown,
        Aquatic,
        Beast,
        Critter,
        Dragonkin,
        Elemental,
        Flying,
        Humanoid,
        Magic,
        Mechanical,
        Undead
    }
}
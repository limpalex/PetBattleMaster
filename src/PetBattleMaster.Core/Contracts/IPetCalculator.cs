using PetBattleMaster.Core.Static;

namespace PetBattleMaster.Core.Contracts
{
    /// <summary>
    /// Contains utility methods for pet parameters calculation.
    /// </summary>
    public interface IPetCalculator
    {
        /// <summary>
        /// Calculates pet health.
        /// </summary>
        /// <param name="breed">Pet breed.</param>
        /// <param name="quality">Pet quality.</param>
        /// <param name="baseValue">Base health value.</param>
        /// <param name="level">Pet level.</param>
        /// <returns>Pet maximum health.</returns>
        int CalculateHealth(PetBreed breed, PetQuality quality, int baseValue, int level);

        /// <summary>
        /// Calculates pet speed.
        /// </summary>
        /// <param name="breed">Pet breed.</param>
        /// <param name="quality">Pet quality.</param>
        /// <param name="baseValue">Base speed value.</param>
        /// <param name="level">Pet level.</param>
        /// <returns>Pet speed.</returns>
        int CalculateSpeed(PetBreed breed, PetQuality quality, int baseValue, int level);

        /// <summary>
        /// Calculates pet power.
        /// </summary>
        /// <param name="breed">Pet breed.</param>
        /// <param name="quality">Pet quality.</param>
        /// <param name="baseValue">Base health value.</param>
        /// <param name="level">Pet level.</param>
        /// <returns>Pet power.</returns>
        int CalculatePower(PetBreed breed, PetQuality quality, int baseValue, int level);

        /// <summary>
        /// Returns <value>true</value> if <paramref name="ability"/> is empowered against pet family <paramref name="target"/>.
        /// </summary>
        /// <param name="ability">Ability type.</param>
        /// <param name="target">Pet family.</param>
        /// <returns><value>true</value> or <value>false</value>.</returns>
        bool IsEmpowered(PetFamily ability, PetFamily target);

        /// <summary>
        /// Returns <value>true</value> if <paramref name="ability"/> is weakened against pet family <paramref name="target"/>.
        /// </summary>
        /// <param name="ability">Ability type.</param>
        /// <param name="target">Pet family.</param>
        /// <returns><value>true</value> or <value>false</value>.</returns>
        bool IsWeakened(PetFamily ability, PetFamily target);

        /// <summary>
        /// Returns <see cref="PetFamily"/> that is being empowered by <paramref name="ability"/>.
        /// </summary>
        /// <param name="ability">Ability type.</param>
        /// <returns><see cref="PetFamily"/> that is being empowered by <paramref name="ability"/>.</returns>
        PetFamily EmpoweredVs(PetFamily ability);

        /// <summary>
        /// Returns <see cref="PetFamily"/> that is being weakened by <paramref name="ability"/>.
        /// </summary>
        /// <param name="ability">Ability type.</param>
        /// <returns><see cref="PetFamily"/> that is being weakened by <paramref name="ability"/>.</returns>
        PetFamily WeakenedVs(PetFamily ability);

        /// <summary>
        /// Returns ability type that empowers against specified <paramref name="family"/>.
        /// </summary>
        /// <param name="family">Pet family.</param>
        /// <returns>Ability type that empowers against specified <paramref name="family"/>.</returns>
        PetFamily EmpoweredBy(PetFamily family);

        /// <summary>
        /// Returns ability type that weakens against specified <paramref name="family"/>.
        /// </summary>
        /// <param name="family">Pet family.</param>
        /// <returns>Ability type that weakens agains specified <paramref name="family"/>.</returns>
        PetFamily WeakenedBy(PetFamily family);
    }
}
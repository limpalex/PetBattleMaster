using System;
using System.Collections.Generic;
using System.Linq;
using PetBattleMaster.Core.Contracts;
using PetBattleMaster.Core.Static;

namespace PetBattleMaster.Core.Utils
{
    internal class PetCalculator : IPetCalculator
    {
        private static readonly Dictionary<PetFamily, PetFamily> EmpoweredTable, EmpoweredByTable, WeakenedTable, WeakenedByTable;
        private static readonly Dictionary<PetBreed, int>        PowerMultipliers, SpeedMultipliers, HealthMultipliers;
        private static readonly Dictionary<PetQuality, decimal>  QualityMultipliers;

        static PetCalculator()
        {
            EmpoweredTable = new Dictionary<PetFamily, PetFamily>
            {
                [PetFamily.Aquatic]    = PetFamily.Elemental,
                [PetFamily.Beast]      = PetFamily.Critter,
                [PetFamily.Critter]    = PetFamily.Undead,
                [PetFamily.Dragonkin]  = PetFamily.Magic,
                [PetFamily.Elemental]  = PetFamily.Mechanical,
                [PetFamily.Flying]     = PetFamily.Aquatic,
                [PetFamily.Humanoid]   = PetFamily.Dragonkin,
                [PetFamily.Magic]      = PetFamily.Flying,
                [PetFamily.Mechanical] = PetFamily.Beast,
                [PetFamily.Undead]     = PetFamily.Humanoid
            };
            EmpoweredByTable = EmpoweredTable.ToDictionary(p => p.Value, p => p.Key);

            WeakenedTable = new Dictionary<PetFamily, PetFamily>
            {
                [PetFamily.Aquatic]    = PetFamily.Magic,
                [PetFamily.Beast]      = PetFamily.Flying,
                [PetFamily.Critter]    = PetFamily.Humanoid,
                [PetFamily.Dragonkin]  = PetFamily.Undead,
                [PetFamily.Elemental]  = PetFamily.Critter,
                [PetFamily.Flying]     = PetFamily.Dragonkin,
                [PetFamily.Humanoid]   = PetFamily.Beast,
                [PetFamily.Magic]      = PetFamily.Mechanical,
                [PetFamily.Mechanical] = PetFamily.Elemental,
                [PetFamily.Undead]     = PetFamily.Aquatic
            };
            WeakenedByTable = WeakenedTable.ToDictionary(p => p.Value, p => p.Key);

            PowerMultipliers = new Dictionary<PetBreed, int>
            {
                [PetBreed.Power]         = 20,
                [PetBreed.PowerBalance]  = 9,
                [PetBreed.Balance]       = 5,
                [PetBreed.HealthBalance] = 4,
                [PetBreed.SpeedBalance]  = 4,
                [PetBreed.Health]        = 0,
                [PetBreed.Speed]         = 0
            };

            SpeedMultipliers = new Dictionary<PetBreed, int>
            {
                [PetBreed.Speed]         = 20,
                [PetBreed.SpeedBalance]  = 9,
                [PetBreed.Balance]       = 5,
                [PetBreed.HealthBalance] = 4,
                [PetBreed.PowerBalance]  = 4,
                [PetBreed.Health]        = 0,
                [PetBreed.Power]         = 0
            };

            HealthMultipliers = new Dictionary<PetBreed, int>
            {
                [PetBreed.Health]        = 20,
                [PetBreed.HealthBalance] = 9,
                [PetBreed.Balance]       = 5,
                [PetBreed.SpeedBalance]  = 4,
                [PetBreed.PowerBalance]  = 4,
                [PetBreed.Speed]         = 0,
                [PetBreed.Power]         = 0
            };

            QualityMultipliers = new Dictionary<PetQuality, decimal>
            {
                [PetQuality.Poor]      = 1,
                [PetQuality.Common]    = 1.1m,
                [PetQuality.Uncommon]  = 1.2m,
                [PetQuality.Rare]      = 1.3m,
                [PetQuality.Epic]      = 1.4m,
                [PetQuality.Legendary] = 1.5m
            };
        }

        int IPetCalculator.CalculateHealth(PetBreed breed, PetQuality quality, int baseValue, int level)
        {
            var breedMultiplier = HealthMultipliers[breed];
            var qualityMultiplier = QualityMultipliers[quality];

            return (int)Math.Ceiling((baseValue + breedMultiplier / 10m) * level * qualityMultiplier * 5 + 100);
        }

        int IPetCalculator.CalculateSpeed(PetBreed breed, PetQuality quality, int baseValue, int level)
        {
            var breedMultiplier = SpeedMultipliers[breed];
            var qualityMultiplier = QualityMultipliers[quality];

            return (int)Math.Ceiling((baseValue + breedMultiplier / 10m) * level * qualityMultiplier);
        }

        int IPetCalculator.CalculatePower(PetBreed breed, PetQuality quality, int baseValue, int level)
        {
            var breedMultiplier = PowerMultipliers[breed];
            var qualityMultiplier = QualityMultipliers[quality];

            return (int)Math.Ceiling((baseValue + breedMultiplier / 10m) * level * qualityMultiplier);
        }

        bool IPetCalculator.IsEmpowered(PetFamily ability, PetFamily target)
        {
            return EmpoweredTable[ability] == target;
        }

        bool IPetCalculator.IsWeakened(PetFamily ability, PetFamily target)
        {
            return WeakenedTable[ability] == target;
        }

        PetFamily IPetCalculator.EmpoweredVs(PetFamily ability)
        {
            return EmpoweredTable[ability];
        }

        PetFamily IPetCalculator.WeakenedVs(PetFamily ability)
        {
            return WeakenedTable[ability];
        }

        PetFamily IPetCalculator.EmpoweredBy(PetFamily family)
        {
            return EmpoweredByTable[family];
        }

        PetFamily IPetCalculator.WeakenedBy(PetFamily family)
        {
            return WeakenedByTable[family];
        }
    }
}


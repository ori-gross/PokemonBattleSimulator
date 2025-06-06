﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattleSimulator.Models.Enums;

namespace PokemonBattleSimulator.Utilities.Classes
{
    public static class TypeEffectivenessMatrix
    {
        private static readonly Dictionary<(PokemonType attacker, PokemonType defender), TypeEffectiveness> _effectiveness;

        static TypeEffectivenessMatrix()
        {
            _effectiveness = new Dictionary<(PokemonType, PokemonType), TypeEffectiveness>
            {
                { (PokemonType.Normal, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Fire), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Water), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Grass), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Fighting), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Poison), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Ground), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Flying), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Bug), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Rock), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Normal, PokemonType.Ghost), TypeEffectiveness.NoEffect },
                { (PokemonType.Normal, PokemonType.Dragon), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Dark), TypeEffectiveness.Normal },
                { (PokemonType.Normal, PokemonType.Steel), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Normal, PokemonType.Fairy), TypeEffectiveness.Normal },

                { (PokemonType.Fire, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Fire, PokemonType.Fire), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Fire, PokemonType.Water), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Fire, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Fire, PokemonType.Grass), TypeEffectiveness.SuperEffective },
                { (PokemonType.Fire, PokemonType.Ice), TypeEffectiveness.SuperEffective },
                { (PokemonType.Fire, PokemonType.Fighting), TypeEffectiveness.Normal },
                { (PokemonType.Fire, PokemonType.Poison), TypeEffectiveness.Normal },
                { (PokemonType.Fire, PokemonType.Ground), TypeEffectiveness.Normal },
                { (PokemonType.Fire, PokemonType.Flying), TypeEffectiveness.Normal },
                { (PokemonType.Fire, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Fire, PokemonType.Bug), TypeEffectiveness.SuperEffective },
                { (PokemonType.Fire, PokemonType.Rock), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Fire, PokemonType.Ghost), TypeEffectiveness.Normal },
                { (PokemonType.Fire, PokemonType.Dragon), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Fire, PokemonType.Dark), TypeEffectiveness.Normal },
                { (PokemonType.Fire, PokemonType.Steel), TypeEffectiveness.SuperEffective },
                { (PokemonType.Fire, PokemonType.Fairy), TypeEffectiveness.Normal },

                { (PokemonType.Water, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Water, PokemonType.Fire), TypeEffectiveness.SuperEffective },
                { (PokemonType.Water, PokemonType.Water), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Water, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Water, PokemonType.Grass), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Water, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Water, PokemonType.Fighting), TypeEffectiveness.Normal },
                { (PokemonType.Water, PokemonType.Poison), TypeEffectiveness.Normal },
                { (PokemonType.Water, PokemonType.Ground), TypeEffectiveness.SuperEffective },
                { (PokemonType.Water, PokemonType.Flying), TypeEffectiveness.Normal },
                { (PokemonType.Water, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Water, PokemonType.Bug), TypeEffectiveness.Normal },
                { (PokemonType.Water, PokemonType.Rock), TypeEffectiveness.SuperEffective },
                { (PokemonType.Water, PokemonType.Ghost), TypeEffectiveness.Normal },
                { (PokemonType.Water, PokemonType.Dragon), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Water, PokemonType.Dark), TypeEffectiveness.Normal },
                { (PokemonType.Water, PokemonType.Steel), TypeEffectiveness.Normal },
                { (PokemonType.Water, PokemonType.Fairy), TypeEffectiveness.Normal },

                { (PokemonType.Electric, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Electric, PokemonType.Fire), TypeEffectiveness.Normal },
                { (PokemonType.Electric, PokemonType.Water), TypeEffectiveness.SuperEffective },
                { (PokemonType.Electric, PokemonType.Electric), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Electric, PokemonType.Grass), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Electric, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Electric, PokemonType.Fighting), TypeEffectiveness.Normal },
                { (PokemonType.Electric, PokemonType.Poison), TypeEffectiveness.Normal },
                { (PokemonType.Electric, PokemonType.Ground), TypeEffectiveness.NoEffect },
                { (PokemonType.Electric, PokemonType.Flying), TypeEffectiveness.SuperEffective },
                { (PokemonType.Electric, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Electric, PokemonType.Bug), TypeEffectiveness.Normal },
                { (PokemonType.Electric, PokemonType.Rock), TypeEffectiveness.Normal },
                { (PokemonType.Electric, PokemonType.Ghost), TypeEffectiveness.Normal },
                { (PokemonType.Electric, PokemonType.Dragon), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Electric, PokemonType.Dark), TypeEffectiveness.Normal },
                { (PokemonType.Electric, PokemonType.Steel), TypeEffectiveness.Normal },
                { (PokemonType.Electric, PokemonType.Fairy), TypeEffectiveness.Normal },

                { (PokemonType.Grass, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Grass, PokemonType.Fire), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Grass, PokemonType.Water), TypeEffectiveness.SuperEffective },
                { (PokemonType.Grass, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Grass, PokemonType.Grass), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Grass, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Grass, PokemonType.Fighting), TypeEffectiveness.Normal },
                { (PokemonType.Grass, PokemonType.Poison), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Grass, PokemonType.Ground), TypeEffectiveness.SuperEffective },
                { (PokemonType.Grass, PokemonType.Flying), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Grass, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Grass, PokemonType.Bug), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Grass, PokemonType.Rock), TypeEffectiveness.SuperEffective },
                { (PokemonType.Grass, PokemonType.Ghost), TypeEffectiveness.Normal },
                { (PokemonType.Grass, PokemonType.Dragon), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Grass, PokemonType.Dark), TypeEffectiveness.Normal },
                { (PokemonType.Grass, PokemonType.Steel), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Grass, PokemonType.Fairy), TypeEffectiveness.Normal },

                { (PokemonType.Ice, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Ice, PokemonType.Fire), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Ice, PokemonType.Water), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Ice, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Ice, PokemonType.Grass), TypeEffectiveness.SuperEffective },
                { (PokemonType.Ice, PokemonType.Ice), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Ice, PokemonType.Fighting), TypeEffectiveness.Normal },
                { (PokemonType.Ice, PokemonType.Poison), TypeEffectiveness.Normal },
                { (PokemonType.Ice, PokemonType.Ground), TypeEffectiveness.SuperEffective },
                { (PokemonType.Ice, PokemonType.Flying), TypeEffectiveness.SuperEffective },
                { (PokemonType.Ice, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Ice, PokemonType.Bug), TypeEffectiveness.Normal },
                { (PokemonType.Ice, PokemonType.Rock), TypeEffectiveness.Normal },
                { (PokemonType.Ice, PokemonType.Ghost), TypeEffectiveness.Normal },
                { (PokemonType.Ice, PokemonType.Dragon), TypeEffectiveness.SuperEffective },
                { (PokemonType.Ice, PokemonType.Dark), TypeEffectiveness.Normal },
                { (PokemonType.Ice, PokemonType.Steel), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Ice, PokemonType.Fairy), TypeEffectiveness.Normal },

                { (PokemonType.Fighting, PokemonType.Normal), TypeEffectiveness.SuperEffective },
                { (PokemonType.Fighting, PokemonType.Fire), TypeEffectiveness.Normal },
                { (PokemonType.Fighting, PokemonType.Water), TypeEffectiveness.Normal },
                { (PokemonType.Fighting, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Fighting, PokemonType.Grass), TypeEffectiveness.Normal },
                { (PokemonType.Fighting, PokemonType.Ice), TypeEffectiveness.SuperEffective },
                { (PokemonType.Fighting, PokemonType.Fighting), TypeEffectiveness.Normal },
                { (PokemonType.Fighting, PokemonType.Poison), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Fighting, PokemonType.Ground), TypeEffectiveness.Normal },
                { (PokemonType.Fighting, PokemonType.Flying), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Fighting, PokemonType.Psychic), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Fighting, PokemonType.Bug), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Fighting, PokemonType.Rock), TypeEffectiveness.SuperEffective },
                { (PokemonType.Fighting, PokemonType.Ghost), TypeEffectiveness.NoEffect },
                { (PokemonType.Fighting, PokemonType.Dragon), TypeEffectiveness.Normal },
                { (PokemonType.Fighting, PokemonType.Dark), TypeEffectiveness.SuperEffective },
                { (PokemonType.Fighting, PokemonType.Steel), TypeEffectiveness.SuperEffective },
                { (PokemonType.Fighting, PokemonType.Fairy), TypeEffectiveness.NotVeryEffective },

                { (PokemonType.Poison, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Poison, PokemonType.Fire), TypeEffectiveness.Normal },
                { (PokemonType.Poison, PokemonType.Water), TypeEffectiveness.Normal },
                { (PokemonType.Poison, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Poison, PokemonType.Grass), TypeEffectiveness.SuperEffective },
                { (PokemonType.Poison, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Poison, PokemonType.Fighting), TypeEffectiveness.Normal },
                { (PokemonType.Poison, PokemonType.Poison), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Poison, PokemonType.Ground), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Poison, PokemonType.Flying), TypeEffectiveness.Normal },
                { (PokemonType.Poison, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Poison, PokemonType.Bug), TypeEffectiveness.Normal },
                { (PokemonType.Poison, PokemonType.Rock), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Poison, PokemonType.Ghost), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Poison, PokemonType.Dragon), TypeEffectiveness.Normal },
                { (PokemonType.Poison, PokemonType.Dark), TypeEffectiveness.Normal },
                { (PokemonType.Poison, PokemonType.Steel), TypeEffectiveness.NoEffect },
                { (PokemonType.Poison, PokemonType.Fairy), TypeEffectiveness.SuperEffective },

                { (PokemonType.Ground, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Ground, PokemonType.Fire), TypeEffectiveness.SuperEffective },
                { (PokemonType.Ground, PokemonType.Water), TypeEffectiveness.Normal },
                { (PokemonType.Ground, PokemonType.Electric), TypeEffectiveness.SuperEffective },
                { (PokemonType.Ground, PokemonType.Grass), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Ground, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Ground, PokemonType.Fighting), TypeEffectiveness.Normal },
                { (PokemonType.Ground, PokemonType.Poison), TypeEffectiveness.SuperEffective },
                { (PokemonType.Ground, PokemonType.Ground), TypeEffectiveness.Normal },
                { (PokemonType.Ground, PokemonType.Flying), TypeEffectiveness.NoEffect },
                { (PokemonType.Ground, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Ground, PokemonType.Bug), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Ground, PokemonType.Rock), TypeEffectiveness.SuperEffective },
                { (PokemonType.Ground, PokemonType.Ghost), TypeEffectiveness.Normal },
                { (PokemonType.Ground, PokemonType.Dragon), TypeEffectiveness.Normal },
                { (PokemonType.Ground, PokemonType.Dark), TypeEffectiveness.Normal },
                { (PokemonType.Ground, PokemonType.Steel), TypeEffectiveness.SuperEffective },
                { (PokemonType.Ground, PokemonType.Fairy), TypeEffectiveness.Normal },

                { (PokemonType.Flying, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Flying, PokemonType.Fire), TypeEffectiveness.Normal },
                { (PokemonType.Flying, PokemonType.Water), TypeEffectiveness.Normal },
                { (PokemonType.Flying, PokemonType.Electric), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Flying, PokemonType.Grass), TypeEffectiveness.SuperEffective },
                { (PokemonType.Flying, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Flying, PokemonType.Fighting), TypeEffectiveness.SuperEffective },
                { (PokemonType.Flying, PokemonType.Poison), TypeEffectiveness.Normal },
                { (PokemonType.Flying, PokemonType.Ground), TypeEffectiveness.Normal },
                { (PokemonType.Flying, PokemonType.Flying), TypeEffectiveness.Normal },
                { (PokemonType.Flying, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Flying, PokemonType.Bug), TypeEffectiveness.SuperEffective },
                { (PokemonType.Flying, PokemonType.Rock), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Flying, PokemonType.Ghost), TypeEffectiveness.Normal },
                { (PokemonType.Flying, PokemonType.Dragon), TypeEffectiveness.Normal },
                { (PokemonType.Flying, PokemonType.Dark), TypeEffectiveness.Normal },
                { (PokemonType.Flying, PokemonType.Steel), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Flying, PokemonType.Fairy), TypeEffectiveness.Normal },

                { (PokemonType.Psychic, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Psychic, PokemonType.Fire), TypeEffectiveness.Normal },
                { (PokemonType.Psychic, PokemonType.Water), TypeEffectiveness.Normal },
                { (PokemonType.Psychic, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Psychic, PokemonType.Grass), TypeEffectiveness.Normal },
                { (PokemonType.Psychic, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Psychic, PokemonType.Fighting), TypeEffectiveness.SuperEffective },
                { (PokemonType.Psychic, PokemonType.Poison), TypeEffectiveness.SuperEffective },
                { (PokemonType.Psychic, PokemonType.Ground), TypeEffectiveness.Normal },
                { (PokemonType.Psychic, PokemonType.Flying), TypeEffectiveness.Normal },
                { (PokemonType.Psychic, PokemonType.Psychic), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Psychic, PokemonType.Bug), TypeEffectiveness.Normal },
                { (PokemonType.Psychic, PokemonType.Rock), TypeEffectiveness.Normal },
                { (PokemonType.Psychic, PokemonType.Ghost), TypeEffectiveness.Normal },
                { (PokemonType.Psychic, PokemonType.Dragon), TypeEffectiveness.Normal },
                { (PokemonType.Psychic, PokemonType.Dark), TypeEffectiveness.NoEffect },
                { (PokemonType.Psychic, PokemonType.Steel), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Psychic, PokemonType.Fairy), TypeEffectiveness.Normal },

                { (PokemonType.Bug, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Bug, PokemonType.Fire), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Bug, PokemonType.Water), TypeEffectiveness.Normal },
                { (PokemonType.Bug, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Bug, PokemonType.Grass), TypeEffectiveness.SuperEffective },
                { (PokemonType.Bug, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Bug, PokemonType.Fighting), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Bug, PokemonType.Poison), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Bug, PokemonType.Ground), TypeEffectiveness.Normal },
                { (PokemonType.Bug, PokemonType.Flying), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Bug, PokemonType.Psychic), TypeEffectiveness.SuperEffective },
                { (PokemonType.Bug, PokemonType.Bug), TypeEffectiveness.Normal },
                { (PokemonType.Bug, PokemonType.Rock), TypeEffectiveness.Normal },
                { (PokemonType.Bug, PokemonType.Ghost), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Bug, PokemonType.Dragon), TypeEffectiveness.Normal },
                { (PokemonType.Bug, PokemonType.Dark), TypeEffectiveness.SuperEffective },
                { (PokemonType.Bug, PokemonType.Steel), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Bug, PokemonType.Fairy), TypeEffectiveness.NotVeryEffective },

                { (PokemonType.Rock, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Rock, PokemonType.Fire), TypeEffectiveness.SuperEffective },
                { (PokemonType.Rock, PokemonType.Water), TypeEffectiveness.Normal },
                { (PokemonType.Rock, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Rock, PokemonType.Grass), TypeEffectiveness.Normal },
                { (PokemonType.Rock, PokemonType.Ice), TypeEffectiveness.SuperEffective },
                { (PokemonType.Rock, PokemonType.Fighting), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Rock, PokemonType.Poison), TypeEffectiveness.Normal },
                { (PokemonType.Rock, PokemonType.Ground), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Rock, PokemonType.Flying), TypeEffectiveness.SuperEffective },
                { (PokemonType.Rock, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Rock, PokemonType.Bug), TypeEffectiveness.SuperEffective },
                { (PokemonType.Rock, PokemonType.Rock), TypeEffectiveness.Normal },
                { (PokemonType.Rock, PokemonType.Ghost), TypeEffectiveness.Normal },
                { (PokemonType.Rock, PokemonType.Dragon), TypeEffectiveness.Normal },
                { (PokemonType.Rock, PokemonType.Dark), TypeEffectiveness.Normal },
                { (PokemonType.Rock, PokemonType.Steel), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Rock, PokemonType.Fairy), TypeEffectiveness.Normal },

                { (PokemonType.Ghost, PokemonType.Normal), TypeEffectiveness.NoEffect },
                { (PokemonType.Ghost, PokemonType.Fire), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Water), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Grass), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Fighting), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Poison), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Ground), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Flying), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Psychic), TypeEffectiveness.SuperEffective },
                { (PokemonType.Ghost, PokemonType.Bug), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Rock), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Ghost), TypeEffectiveness.SuperEffective },
                { (PokemonType.Ghost, PokemonType.Dragon), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Dark), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Ghost, PokemonType.Steel), TypeEffectiveness.Normal },
                { (PokemonType.Ghost, PokemonType.Fairy), TypeEffectiveness.Normal },

                { (PokemonType.Dragon, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Fire), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Water), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Grass), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Fighting), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Poison), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Ground), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Flying), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Bug), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Rock), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Ghost), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Dragon), TypeEffectiveness.SuperEffective },
                { (PokemonType.Dragon, PokemonType.Dark), TypeEffectiveness.Normal },
                { (PokemonType.Dragon, PokemonType.Steel), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Dragon, PokemonType.Fairy), TypeEffectiveness.NoEffect },

                { (PokemonType.Dark, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Fire), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Water), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Grass), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Fighting), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Dark, PokemonType.Poison), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Ground), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Flying), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Psychic), TypeEffectiveness.SuperEffective },
                { (PokemonType.Dark, PokemonType.Bug), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Rock), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Ghost), TypeEffectiveness.SuperEffective },
                { (PokemonType.Dark, PokemonType.Dragon), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Dark), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Dark, PokemonType.Steel), TypeEffectiveness.Normal },
                { (PokemonType.Dark, PokemonType.Fairy), TypeEffectiveness.NotVeryEffective },

                { (PokemonType.Steel, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Steel, PokemonType.Fire), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Steel, PokemonType.Water), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Steel, PokemonType.Electric), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Steel, PokemonType.Grass), TypeEffectiveness.Normal },
                { (PokemonType.Steel, PokemonType.Ice), TypeEffectiveness.SuperEffective },
                { (PokemonType.Steel, PokemonType.Fighting), TypeEffectiveness.Normal },
                { (PokemonType.Steel, PokemonType.Poison), TypeEffectiveness.Normal },
                { (PokemonType.Steel, PokemonType.Ground), TypeEffectiveness.Normal },
                { (PokemonType.Steel, PokemonType.Flying), TypeEffectiveness.Normal },
                { (PokemonType.Steel, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Steel, PokemonType.Bug), TypeEffectiveness.Normal },
                { (PokemonType.Steel, PokemonType.Rock), TypeEffectiveness.SuperEffective },
                { (PokemonType.Steel, PokemonType.Ghost), TypeEffectiveness.Normal },
                { (PokemonType.Steel, PokemonType.Dragon), TypeEffectiveness.Normal },
                { (PokemonType.Steel, PokemonType.Dark), TypeEffectiveness.Normal },
                { (PokemonType.Steel, PokemonType.Steel), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Steel, PokemonType.Fairy), TypeEffectiveness.SuperEffective },

                { (PokemonType.Fairy, PokemonType.Normal), TypeEffectiveness.Normal },
                { (PokemonType.Fairy, PokemonType.Fire), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Fairy, PokemonType.Water), TypeEffectiveness.Normal },
                { (PokemonType.Fairy, PokemonType.Electric), TypeEffectiveness.Normal },
                { (PokemonType.Fairy, PokemonType.Grass), TypeEffectiveness.Normal },
                { (PokemonType.Fairy, PokemonType.Ice), TypeEffectiveness.Normal },
                { (PokemonType.Fairy, PokemonType.Fighting), TypeEffectiveness.SuperEffective },
                { (PokemonType.Fairy, PokemonType.Poison), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Fairy, PokemonType.Ground), TypeEffectiveness.Normal },
                { (PokemonType.Fairy, PokemonType.Flying), TypeEffectiveness.Normal },
                { (PokemonType.Fairy, PokemonType.Psychic), TypeEffectiveness.Normal },
                { (PokemonType.Fairy, PokemonType.Bug), TypeEffectiveness.Normal },
                { (PokemonType.Fairy, PokemonType.Rock), TypeEffectiveness.Normal },
                { (PokemonType.Fairy, PokemonType.Ghost), TypeEffectiveness.Normal },
                { (PokemonType.Fairy, PokemonType.Dragon), TypeEffectiveness.SuperEffective },
                { (PokemonType.Fairy, PokemonType.Dark), TypeEffectiveness.SuperEffective },
                { (PokemonType.Fairy, PokemonType.Steel), TypeEffectiveness.NotVeryEffective },
                { (PokemonType.Fairy, PokemonType.Fairy), TypeEffectiveness.Normal }
            };
        }

        public static TypeEffectiveness GetEffectiveness(PokemonType attacker, PokemonType defender)
        {
            if (_effectiveness.TryGetValue((attacker, defender), out var value))
            {
                return value;
            }
            return TypeEffectiveness.Normal;
        }
    }

}

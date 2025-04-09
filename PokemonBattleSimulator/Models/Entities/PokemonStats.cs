using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator.Models.Entities
{
    public class PokemonStats
    {
        private int _hp;
        private int _attack;
        private int _defense;
        private int _specialAttack;
        private int _specialDefense;
        private int _speed;
        
        public int HP
        {
            get { return _hp; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("HP cannot be negative.");
                }
                _hp = value;
            }
        }

        public int Attack
        {
            get { return _attack; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Attack cannot be negative.");
                }
                _attack = value;
            }
        }
        
        public int Defense
        {
            get { return _defense; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Defense cannot be negative.");
                }
                _defense = value;
            }
        }
        
        public int SpecialAttack
        {
            get { return _specialAttack; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Special Attack cannot be negative.");
                }
                _specialAttack = value;
            }
        }
        
        public int SpecialDefense
        {
            get { return _specialDefense; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Special Defense cannot be negative.");
                }
                _specialDefense = value;
            }
        }
        
        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Speed cannot be negative.");
                }
                _speed = value;
            }
        }
        
        public PokemonStats(int hp, int attack, int defense, int specialAttack, int specialDefense, int speed)
        {
            HP = hp;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            Speed = speed;
        }
    }
}

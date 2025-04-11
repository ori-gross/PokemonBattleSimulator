using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattleSimulator.Models.Entities
{
    public class PokemonSpriteSet
    {
        private string _frontImageMalePath;
        private string _frontImageFemalePath;
        private string _backImageMalePath;
        private string _backImageFemalePath;
        private string _iconImagePath;

        public string FrontImageMalePath
        {
            get { return _frontImageMalePath; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Front image male path cannot be null or empty.");
                }
                _frontImageMalePath = value;
            }
        }

        public string FrontImageFemalePath
        {
            get { return _frontImageFemalePath; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Front image female path cannot be null or empty.");
                }
                _frontImageFemalePath = value;
            }
        }

        public string BackImageMalePath
        {
            get { return _backImageMalePath; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Back image male path cannot be null or empty.");
                }
                _backImageMalePath = value;
            }
        }

        public string BackImageFemalePath
        {
            get { return _backImageFemalePath; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Back image female path cannot be null or empty.");
                }
                _backImageFemalePath = value;
            }
        }

        public string IconImagePath
        {
            get { return _iconImagePath; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Icon image path cannot be null or empty.");
                }
                _iconImagePath = value;
            }
        }

        public PokemonSpriteSet(string frontImageMalePath, string frontImageFemalePath, string backImageMalePath, string backImageFemalePath, string iconImagePath)
        {
            FrontImageMalePath = frontImageMalePath;
            FrontImageFemalePath = frontImageFemalePath;
            BackImageMalePath = backImageMalePath;
            BackImageFemalePath = backImageFemalePath;
            IconImagePath = iconImagePath;
        }
    }
}

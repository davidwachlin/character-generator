using System;
namespace CharacterLibrary
{
    public class Character
    {
        public Character()
        {
        }

        public string CharacterName { get; set; }

        private int _strength;
        public int Strength
        {
            get { return _strength; }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _strength = value;
                }
                else
                {
                    throw new Exception("Strength must be between 3 and 18");
                }
            }
        }

        private int _intelligence;
        public int Intelligence
        {
            get
            {
                return _intelligence;
            }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _intelligence = value;
                }
                else
                {
                    throw new Exception("Intelligence must be between 3 and 18");
                }
            }
        }
        private int _wisdom;
        public int Wisdom
        {
            get
            {
                return _wisdom;
            }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _wisdom = value;
                }
                else
                {
                    throw new Exception("Wisdom must be between 3 and 18");
                }
            }
        }

        private int _dexterity;
        public int Dexterity
        {
            get
            {
                return _dexterity;
            }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _dexterity = value;
                }
                else
                {
                    throw new Exception("Dexterity must be between 3 and 18");
                }
            }
        }


        private int _constitution;
        public int Constitution
        {
            get
            {
                return _constitution;
            }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _constitution = value;
                }
                else
                {
                    throw new Exception("Constitution must be between 3 and 18");
                }
            }
        }

        private int _charisma;
        public int Charisma
        {
            get
            {
                return _charisma;
            }
            set
            {
                if (value >= 3 && value <= 18)
                {
                    _charisma = value;
                }
                else
                {
                    throw new Exception("Charisma must be between 3 and 18");
                }
            }
        }


    }
}

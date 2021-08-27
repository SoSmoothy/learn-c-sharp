using System;

namespace basic_about_c_sharp.OOPInCSharp.Model.Base
{
    internal enum Gender : sbyte
    {
        Male = 1,
        Female = 2,
        Unknown = 3
    }

    public abstract class BaseCharacter
    {
        private String _name;
        private Gender _gender;
        private double _hp;
        private double _mana;
        private double _atk;

        public abstract void Attack();
        public abstract void BlockAtk();
    }
}
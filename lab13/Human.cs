﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Laba_13
{
    [Serializable]
    public class Human : IntelligentBeing
    {
        public string Gender; // Убрали null!

        public Human(string name, DateTime age, string gender) : base(name, age)
        {
            Gender = gender;
        }

        public Human(string name, DateTime age) : base(name, age)
        {
        }

        public Human() : base("undefined", DateTime.Now)
        {
            Gender = "undefined";
        }

        public override string ToString()
        {
            return $"name: {Name}\t age: {AgeInYears} days\t gender: {Gender}";
        }
    }
}

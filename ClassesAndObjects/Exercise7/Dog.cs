using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    class Dog
    {
        private string name, sex;
        private Dog mother, father;

        public Dog(string name, string sex)
        {
            this.name = name;
            this.sex = sex;
        }

        public string Name
        { get { return this.name; } }

        public string Sex
        { get { return this.sex; } }

        public Dog Mother
        { get { return this.mother; } set { this.mother = value; } }
        public Dog Father
        { get { return this.father; } set { this.father = value; } }

        public string FathersName()
        {
            if (this.Father == null) return "Unknown";
            return this.Father.Name;
        }

        public bool HasSameMotherAs(Dog checkThisDog)
        {
            return this.Mother == checkThisDog.Mother;
        }


    }
}

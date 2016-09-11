using System;
using System.Collections.Generic;

namespace TestApplication
{
    public class Person : IEquatable<Person>
    {
        public string Name { get; set; }
        public Expense Expense { get; set; }
        List<Partner> Patners;

        public Person()
        {
            this.Expense = new Expense();
            this.Patners = new List<Partner>();
        }

        public bool Equals(Person other)
        {
            if (this.Name.Equals(other.Name))
                return true;
            return false;
        }
    }
}

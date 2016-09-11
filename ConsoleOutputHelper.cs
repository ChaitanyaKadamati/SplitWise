using System;
using System.Collections.Generic;

namespace TestApplication
{
    public class ConsoleOutputHelper : IOutputHelper
    {
        public void DisplayResult(IWriter writer, List<Person> Persons)
        {
            foreach (var person in Persons)
            {
                if (person.Expense.Money > 0)
                    writer.Write(person.Name + " gets " + person.Expense.Money);
                else if (person.Expense.Money < 0)
                    writer.Write(person.Name + " has to give " + Math.Abs(person.Expense.Money));
                else
                    writer.Write(person.Name + " is settled");
            }
        }
    }
}

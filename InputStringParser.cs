using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestApplication
{
    public class InputStringParser : IInputParser
    {
        private List<Person> Persons;

        public InputStringParser(List<Person> Persons)
        {
            // TODO: Complete member initialization
            this.Persons = Persons;
        }
        public void ProcessInput(string input)
        {
            string[] split1 = Regex.Split(input, " spent ");
            string spentBy = split1[0];
            string[] split2 = Regex.Split(split1[1], " for ");
            float howMuchSpent = float.Parse(split2[0]);
            string[] sharedBy = Regex.Split(split2[2].Replace(" and ", ","), ",");
            float chargesPerHead = howMuchSpent / sharedBy.Count();

            UpdatePersonInformation(spentBy);
            UpdateSpent(spentBy, howMuchSpent);

            foreach (string name in sharedBy)
            {
                UpdatePersonInformation(name);
                UpdateBorrow(name, chargesPerHead);
            }
        }

        private void UpdateSpent(string spentBy, float howMuchSpent)
        {
            Person person = GerPerson(spentBy);
            person.Expense.UpdateSpent(howMuchSpent);
        }

        private void UpdatePersonInformation(string p)
        {
            Person person = new Person { Name = p };
            if (! this.Persons.Contains(person))
            {
                this.Persons.Add(person);
            }
        }

        private void UpdateBorrow(string name, float chargesPerHead)
        {
            Person person = GerPerson(name);
            person.Expense.UpdateBorrow(chargesPerHead);
        }

        private Person GerPerson(string item)
        {
            return Program.Persons[Program.Persons.IndexOf(new Person { Name = item })];
        }
    }
}

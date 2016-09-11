using System.Collections.Generic;

namespace TestApplication
{
    public interface IOutputHelper
    {
        void DisplayResult(IWriter writer, List<Person> Persons);
    }
}

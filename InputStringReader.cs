using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class InputStringReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}

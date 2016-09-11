using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    public class OutputStringWriter : IWriter
    {
        public void Write(string data)
        {
            Console.WriteLine(data);
        }
    }
}

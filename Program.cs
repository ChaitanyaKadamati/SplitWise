using System;
using System.Collections.Generic;

namespace TestApplication
{
    public class Program
    {
        public static List<Person> Persons = new List<Person>();

        static void Main(string[] args)
        {
            IReader reader = new InputStringReader();
            string input = reader.Read();
            IWriter writer = new OutputStringWriter();
            IInputParser inputParser = new InputStringParser(Persons);
            IOutputHelper outputHelper = new ConsoleOutputHelper();

            while (input.Trim() != "")
            {
                inputParser.ProcessInput(input);
                input = reader.Read();
            }
            outputHelper.DisplayResult(writer, Persons);
            string x = null;
            System.Console.WriteLine(x);
            DateTime y; Console.WriteLine(y);
        }
    }
}

/*
A spent 100 for Snacks for A,B,C and D
B spent 500 for Taxi for C and D
D spent 300 for Bus for A and B
 */
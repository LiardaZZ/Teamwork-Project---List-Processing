namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Interfaces;
    using System;

    public class AppendCommand : IExecutable
    {
        public List<string> Execute(List<string> input, IList<string> commandArgs)
        {
            if (commandArgs.Count != 2)
            {
                Console.WriteLine("Error: invalid command parameters");
                return input;
            }

            //Append a new string to the end of the list
            var stringToAppend = commandArgs[1];
            input.Add(stringToAppend);

            Console.WriteLine(String.Join(" ", input));

            return input;
        }
    }
}

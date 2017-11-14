namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Interfaces;
    using System;

    public class PrependCommand : IExecutable
    {
        public List<string> Execute(List<string> input, IList<string> commandArgs)
        {
            if (commandArgs.Count != 2)
            {
                Console.WriteLine("Error: invalid command parameters");
                return input;
            }

            //add the string to the beginning of the input
            var stringToPrepend = commandArgs[1];
            input.Insert(0, stringToPrepend);

            Console.WriteLine(String.Join(" ", input));
            return input;
        }
    }
}

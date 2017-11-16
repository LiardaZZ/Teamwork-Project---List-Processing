namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Interfaces;
    using System;

    public class ReverseCommand : IExecutable
    {
        public List<string> Execute(List<string> input, IList<string> commandArgs)
        {
            if (commandArgs.Count != 1)
            {
                Console.WriteLine("Error: invalid command parameters");
                return input;
            }

            input.Reverse();

            Console.WriteLine(String.Join(" ", input));

            return input;
        }
    }
}

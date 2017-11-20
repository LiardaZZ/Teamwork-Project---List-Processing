namespace ListProcessing.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ListProcessing.Interfaces;

    public class SortCommand : IExecutable
    {
        public List<string> Execute(List<string> input, IList<string> commandArgs)
        {
            if (!input.Any() || commandArgs.Count != 1)
            {
                Console.WriteLine("Error: invalid command parameters");
                return input;
            }
            var sortedInput = input.OrderBy(x => x).ToList();
            input = sortedInput;
            Console.WriteLine(string.Join(" ",input));
            return input;
        }
    }
}

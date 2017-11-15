namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Interfaces;
    using System;
    using System.Linq;

    public class CountCommand : IExecutable
    {
        public List<string> Execute(List<string> input, IList<string> commandArgs)
        {
            if (commandArgs.Count != 2)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                var times = input.Where(i => i.Contains(commandArgs[1])).Count();
                Console.WriteLine(times);
            }
            return input;
        }
    }
}

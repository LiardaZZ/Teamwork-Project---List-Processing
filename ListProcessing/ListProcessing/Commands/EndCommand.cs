namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Interfaces;
    using System;

    public class EndCommand : IExecutable
    {
        public List<string> Execute(List<string> input, IList<string> commandArgs)
        {
            if (commandArgs.Count != 1)
            {
                Console.WriteLine("Error: invalid command parameters");
            }
            else
            {
                Console.WriteLine("Finished");
            }

            return input;
        }
    }
}

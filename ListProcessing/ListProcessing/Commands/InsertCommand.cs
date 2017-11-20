namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Interfaces;
    using System;

    public class InsertCommand : IExecutable
    {
        public List<string> Execute(List<string> input, IList<string> commandArgs)
        {
            if (commandArgs.Count != 3)
            {
                Console.WriteLine("Error: invalid command parameters");
                return input;
            }
            var isIndexArgANumber = int.TryParse(commandArgs[1], out int index);
            if (!isIndexArgANumber ||
                !(0 <= index && index <= input.Count)) 
            {
                var currentIndex = commandArgs[1];
                Console.WriteLine($"Error: invalid index {currentIndex}");
                return input;
            }
            var itemToInsert = commandArgs[2];
            input.Insert(index, itemToInsert);
            Console.WriteLine(string.Join(" ", input));
            return input;
        }
    }
}

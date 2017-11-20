namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Interfaces;
    using System;

    public class DeleteCommand : IExecutable
    {
        public List<string> Execute(List<string> input, IList<string> commandArgs)
        {
            var isInteger = int.TryParse(commandArgs[1], out int index);

            if (commandArgs.Count != 2 || !isInteger)
            {
                Console.WriteLine("Error: invalid command parameters");
                return input;
            }
            else if (index < 0 || index > input.Count - 1)
            {
                Console.WriteLine($"Error: invalid index {index}");
                return input;
            }

            input.RemoveAt(index);

            Console.WriteLine(String.Join(" ", input));
            return input;
        }
    }
}

namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Interfaces;
    using System;

    public class RollCommand : IExecutable
    {
        private string rollSide;

        public RollCommand(string rollSide)
        {
            this.rollSide = rollSide;
        }

        public List<string> Execute(List<string> input, IList<string> commandArgs)
        {
            if (this.rollSide == string.Empty)
            {
                Console.WriteLine("Error: invalid command parameters");
                return input;
            }
            else if (this.rollSide == "left")
            {
                var firstItemIndex = 0;
                var itemToRoll = input[firstItemIndex];
                input.RemoveAt(firstItemIndex);
                input.Insert(input.Count, itemToRoll);
            }
            else if (this.rollSide == "right")
            {
                var lastItemIndex = input.Count - 1;
                var itemToRoll = input[lastItemIndex];
                input.RemoveAt(lastItemIndex);
                input.Insert(0, itemToRoll);
            }

            Console.WriteLine(String.Join(" ", input));
            return input;
        }
    }
}

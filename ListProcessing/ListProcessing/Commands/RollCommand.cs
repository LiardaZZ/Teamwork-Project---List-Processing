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
            }
            else if(this.rollSide == "left")
            {

            }
            else if (this.rollSide == "right")
            {

            }

            return input;
        }
    }
}

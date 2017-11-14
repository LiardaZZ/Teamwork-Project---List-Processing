namespace ListProcessing
{
    using ListProcessing.Commands;
    using ListProcessing.Interfaces;
    using System;
    using System.Collections.Generic;

    public class Factory
    {
        public Factory()
        {

        }

        public IExecutable CreateCommand(List<string> commandArgs)
        {
            var command = commandArgs[0];

            switch (command)
            {
                case "append":
                    return new AppendCommand();
                case "prepend":
                    return new PrependCommand();
                case "reverse":
                    return new ReverseCommand();
                case "insert":
                    return new InsertCommand();
                case "delete":
                    return new DeleteCommand();
                case "sort":
                    return new SortCommand();
                case "roll":
                    string rollSide = string.Empty;
                    if (commandArgs.Count == 2)
                    {
                        rollSide = commandArgs[1];
                    }
                    return new RollCommand(rollSide);
                case "count":
                    return new CountCommand();
                default:
                    return null;
            }
        }
    }
}

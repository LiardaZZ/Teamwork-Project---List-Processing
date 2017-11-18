namespace ListProcessing
{
    using System;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            Console.WriteLine(String.Join(' ', input));

            var commandArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

            var factory = new Factory(); 

            while (true)
            {
                var command = factory.CreateCommand(commandArgs);

                if (command == null)
                {
                    Console.WriteLine("Error: invalid command");
                }
                else
                {
                   input = command.Execute(input, commandArgs);
                }
                
                if (commandArgs[0] == "end" && commandArgs.Count == 1)
                {
                    break;
                }

                commandArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            }
        }
    }
}

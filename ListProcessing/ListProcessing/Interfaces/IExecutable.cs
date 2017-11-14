namespace ListProcessing.Interfaces
{
    using System.Collections.Generic;

    public interface IExecutable
    {
        List<string> Execute(List<string> input, IList<string> commandArgs);
    }
}

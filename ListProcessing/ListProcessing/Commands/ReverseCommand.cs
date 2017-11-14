﻿namespace ListProcessing.Commands
{
    using System.Collections.Generic;
    using ListProcessing.Interfaces;
    using System;

    public class ReverseCommand : IExecutable
    {
        public List<string> Execute(List<string> input, IList<string> commandArgs)
        {
            return input;
        }
    }
}

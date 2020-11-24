using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] commandArgs = args.Split(' ');
            string commandName = commandArgs[0].ToLower();

            var type = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x=>x.Name.ToLower() == $"{commandName}Command".ToLower());

            ICommand instance = (ICommand)Activator.CreateInstance(type);

            //if (commandArgs[0] == "Hello")
            //{
            //    command = new HelloCommand();
            //}
            //else if (commandArgs[0]=="Exit")
            //{
            //    command = new ExitCommand();
            //}

            string result = instance.Execute(commandArgs
                .Skip(1)
                .ToArray());
            return result;
        }
    }
}

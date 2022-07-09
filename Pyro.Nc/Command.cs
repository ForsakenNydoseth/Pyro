using System;
using System.Threading.Tasks;
using Pyro.IO;

namespace Pyro.Nc
{
    public class Command
    {
        public string Id { get; set; }
        public CommandArgs Args { get; set; }
        public Func<CommandArgs, Task> Function { get; set; }

        public static IPyroLogger Logger { get; set; }

        public Command(CommandArgs args, Func<CommandArgs, Task> function)
        {
            Id = args.Id;
            Args = args;
            Function = function;
            Logger ??= new PyroFileLogger();
        }

        public async Task Invoke() => await Function(Args); 
    }
}
using CommandSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;

namespace Rainbow_Announce_EXILED_SCPSL.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class rbroadcast : ICommand
    {
        public string Command { get; } = "rbroadcast";

        public string[] Aliases { get; } = { "rannounce" };

        public string Description { get; } = "It will do a /broadcast, but in rainbow stylized text.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (arguments != null)
            {
                response = "Alright!";
                int firstArg = int.Parse(arguments.Array[1]) / 5;
                ushort duration = ushort.Parse(firstArg.ToString());
                string text = string.Join(" ", arguments.Array.Skip(2));
                Map.Broadcast(duration, "<color=red>" + text + "</color>");
                Map.Broadcast(duration, "<color=orange>" + text + "</color>");
                Map.Broadcast(duration, "<color=yellow>" + text + "</color>");
                Map.Broadcast(duration, "<color=blue>" + text + "</color>");
                Map.Broadcast(duration, "<color=purple>" + text + "</color>");
                return true;
            }
            else
            {
                response = "Format - (TIME) (TEXT)";
                return false;
            }
        }
    }
}

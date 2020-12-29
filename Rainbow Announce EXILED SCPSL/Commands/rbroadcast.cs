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
                string text = string.Join(" ", arguments);
                Map.Broadcast(1, "<color=red>" + text + "</color>");
                Map.Broadcast(1, "<color=orange>" + text + "</color>");
                Map.Broadcast(1, "<color=yellow>" + text + "</color>");
                Map.Broadcast(1, "<color=blue>" + text + "</color>");
                Map.Broadcast(1, "<color=purple>" + text + "</color>");
                return true;
            }
            else
            {
                response = "Please have text to rbroadcast!";
                return false;
            }
        }
    }
}

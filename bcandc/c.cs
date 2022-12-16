using CommandSystem;
using PlayerRoles;
using PluginAPI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcandc.Commands
{
	[CommandHandler(typeof(ClientCommandHandler))]
	public class c : ICommand
	{

		public string Command { get; } = "c";


		public string[] Aliases { get; } = new string[]
		{
			"c"
		};


		public string Description { get; } = "Team Chat Commands";

		public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
		{
			Player player = sender as Player;
			string text = "";

			if (arguments.Count == 0)
			{
				response = "No text";
				return false;
			}
			foreach (string txt in arguments)
			{
				text = text + txt;
			}
			foreach (Player player1 in Player.GetPlayers())
			{
				if (player1.Role.GetTeam() == player.Role.GetTeam())
				{

					Server.SendBroadcast($"[{player.Role.GetTeam()}][Team]{player.Nickname}: {text}",7 ,global::Broadcast.BroadcastFlags.Normal);

				}
			
			}
			

			response = "Sent successfully";
			return true;
		}
	}
}

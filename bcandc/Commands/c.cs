using CommandSystem;
using Exiled.API.Features;
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
			Player player = Player.Get(sender);
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
			foreach (Player player1 in Player.List)
			{
				if (player1.Team == player.Team)
				{

					Map.Broadcast(7, $"[{player.Team}][Team]{player.Nickname}: {text}", global::Broadcast.BroadcastFlags.Normal);

				}
			
			}
			

			response = "Sent successfully";
			return true;
		}
	}
}

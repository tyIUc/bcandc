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
	public class bc : ICommand
	{
		
		public string Command { get; } = "bc";

	
		public string[] Aliases { get; } = new string[]
		{
			"bc"
		};

	
		public string Description { get; } = "Global Chat Commands-全体聊天";

		public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
		{
			Player player = Player.Get(sender);
			string text = "";

			if (arguments.Count == 0)
			{
				response = "No text ";
				return false;
			}
			foreach (string txt in arguments)
		    {
					text = text + ""+ txt;
			}
			Map.Broadcast(7 , $"[全体]<color={player.Role.Team.GetColor()}>[{player.Nickname}]</color>: {text}", global::Broadcast.BroadcastFlags.Normal);
			
			response = "Sent successfully";
			return true;
		}
	}
}

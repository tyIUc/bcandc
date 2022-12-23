using CommandSystem;
using PlayerRoles;
using PluginAPI.Core;
using RemoteAdmin;
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


		public string Description { get; } = "团队打字指令";

		public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
		{
			Player player = Player.Get(((PlayerCommandSender)sender).ReferenceHub);
			string text = "";

			if (arguments.Count == 0)
			{
				response = "没有输入文本";
				return false;
			}
            foreach (string txt in arguments)
			{
				text = text + txt;
			}
			foreach (Player player1 in Server.GetPlayers())
			{
				
				if (player1.Role.GetTeam() == player.Role.GetTeam())
				{
		

					player1.SendBroadcast( $"[<color=green>{player.Role.ToString()}</color>][<color=yellow>团队</color>]<color=#00BFFF>{player.Nickname}</color>: {text}",7);

				}
			
			}
			

			response = "发送成功";
			return true;
		}
	}
}

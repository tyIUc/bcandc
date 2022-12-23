using CommandSystem;
using MEC;
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
	public class Say : ICommand
	{

		public string Command { get; set; } = "say";

		public string[] Aliases { get; set; } = new string[]
		{
			"bc",

		};


		public string Description { get; set; } = "发送全服广播。";

		public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
		{
			
			Player player = Player.Get(((PlayerCommandSender)sender).ReferenceHub);
			string Say = string.Concat(new string[]
			{
				"<align=left><color=purple>",
				player.Nickname,
				"</color> <color=orange>[",
				Functions.TeamNameToChinese(player.Role.GetTeam()),
				"] 说："
			});
			if (arguments.Count == 0)
			{
				response = "错误：将要显示的文本为空。";
				return false;
			}
			string text = string.Empty;
			foreach (string str in ((IEnumerable<string>)arguments))
			{
				text = text + str + " ";
			}
			Say += text;
			Say += "\n";
			TextData.TextDataVar += Say;
			Server.SendBroadcast(TextData.TextDataVar,5);
			Timing.CallDelayed(5.1f, delegate()
			{
				TextData.TextDataVar = TextData.TextDataVar.Replace(Say, string.Empty);
			});
			response = "<color=purple>完成！</color>";
			return true;
		}
	}
	public class TextData
	{
		public static string TextDataVar = new string('\n', 5);
	}
}

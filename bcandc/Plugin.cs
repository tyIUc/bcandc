using PluginAPI.Core;
using PluginAPI.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcandc
{
    public class Plugin
    {
		[PluginEntryPoint("bcandc", "1.0.0", "Chat", "tyIUc")]
		void Enabled()
		{
			Log.Debug("bcandc PLUGIN Enabled!!");
		}
	}
}

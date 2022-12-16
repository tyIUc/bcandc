using PluginAPI.Core.Attributes;
using System;
using PluginAPI.Events;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginAPI.Core;
using PluginAPI.Commands;

namespace bcandc
{
    public class Plugin
    {
        [PluginEntryPoint("bcandc", "1.0.0", "Chat", "tyIUc")]
        void Enabled()
        {
           //PluginAPI.Events.EventManager.RegisterEvents(this);
            Log.Debug($"bcandc PLUGIN login Enabled v:1.0.0");
           
        }
        //[PluginConfig]
        //public Config Config;
    }
}

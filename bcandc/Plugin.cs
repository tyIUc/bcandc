using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcandc
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "bcandc ";
        public override string Author { get; } = "tyIUc";
        public override Version Version { get; } = new Version(1, 0, 0);

        public override Version RequiredExiledVersion { get; } = new Version(1, 0, 0);
		public override void OnEnabled()
		{
			Log.Debug("bcandc PLUGIN login Enabled");
			base.OnEnabled();
		}

		public override void OnDisabled()
		{

			Log.Debug("bcandc PLUGIN Disabled");
			base.OnDisabled();
		}
	}
}

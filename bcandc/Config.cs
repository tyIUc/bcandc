
using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcandc
{
    public class Config : IConfig
    {
        [Description("Plugin true/false")]
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;


    }
}

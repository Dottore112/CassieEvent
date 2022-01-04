using Exiled.API.Interfaces;
using System.ComponentModel;

namespace Cassiefigo

{
    public class Config : IConfig
    {
        [Description("Enable/Disable the Plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Cassie broadcast")]

        public string Cassiefigo { get; set; } = "Xmas_JingleBells";
    }
} 
    
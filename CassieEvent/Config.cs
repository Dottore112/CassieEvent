using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CassieEventNatale
{
    public class Config : IConfig
    {
        [Description("Enable/Disable the Plugin.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Cassie broadcast")]
        public string Cassiefigo { get; set; } = "Xmas_JingleBells";

        [Description("Broadcast")]
        public Exiled.API.Features.Broadcast BC { get; set; } = new Exiled.API.Features.Broadcast();
    }
}

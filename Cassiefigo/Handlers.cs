using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace Cassiefigo
{
    public class Handlers
    {
        public void OnSpawning(SpawningEventArgs ev)
        {
            if (ev.Player.Role == RoleType.ChaosConscript || ev.Player.Role == RoleType.ChaosMarauder || ev.Player.Role == RoleType.ChaosRepressor || ev.Player.Role == RoleType.ChaosRifleman)
            {
                Cassie.Message(Plugin.Singleton.Config.Cassiefigo, false, true);
            }
        }



    }
}

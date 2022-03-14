using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using ServerEvents = Exiled.Events.Handlers.Server;
using PlayerEvents = Exiled.Events.Handlers.Player;

namespace CassieEventNatale
{
    public class Plugin : Plugin<Config>
    {
        
        
            public Handlers Handlers { get; private set; }
            public override Version Version { get; } = new Version(1, 0, 1);
            public override Version RequiredExiledVersion { get; } = new Version(5, 0, 0);
            



            public static Plugin Singleton;

            public override void OnEnabled()
            {
                Singleton = this;
                Handlers = new Handlers();
                RegisterEvents();
                base.OnEnabled();
            }

            public override void OnDisabled()
            {
                UnregisterEvents();
                base.OnDisabled();
            }

            private void RegisterEvents()
            {
               ServerEvents.WaitingForPlayers += Handlers.Event;
               ServerEvents.WaitingForPlayers += Handlers.BrodcastFigo;
            }

            private void UnregisterEvents()
            {

               ServerEvents.WaitingForPlayers -= Handlers.Event;
               ServerEvents.WaitingForPlayers -= Handlers.BrodcastFigo;
                Handlers = null;
            }

        
    }

}


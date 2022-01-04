using Exiled.API.Features;
using ServerEvents = Exiled.Events.Handlers.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cassiefigo
{
    public class Plugin : Plugin<Config>
    {


        public Handlers Handlers { get; private set; }
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(4, 0, 0);




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
            Handlers = new Handlers();
            ServerEvents.RoundStarted += Handlers.RoundStarted;
        }

        private void UnregisterEvents()
        {
            ServerEvents.RoundStarted -= Handlers.RoundStarted;
            Handlers = null;
        }


    }

}
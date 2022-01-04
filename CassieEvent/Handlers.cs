using Exiled.API.Features;
using Exiled.Events.EventArgs;
using MEC;
using System.Collections.Generic;

namespace CassieEventNatale
{
    public class Handlers
    {
        public void Event()
        {
            Cassie.Message(Plugin.Singleton.Config.Cassiefigo, true); 
        }
        public void BrodcastFigo()
        {
            Timing.RunCoroutine(CassieCoroutine());
            
            
            Map.Broadcast(Plugin.Singleton.Config.BC.Duration, Plugin.Singleton.Config.BC.Content, Broadcast.BroadcastFlags.Normal, true);
        }

        public IEnumerator<float> CassieCoroutine()
        {

             yield return Timing.WaitForSeconds(19f);
            Cassie.Message(Plugin.Singleton.Config.Cassiefigo, true);
            


        }
    }
}

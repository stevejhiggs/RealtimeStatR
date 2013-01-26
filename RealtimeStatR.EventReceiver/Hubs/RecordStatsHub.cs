using Microsoft.AspNet.SignalR;
using System;
using System.Threading.Tasks;

namespace RealtimeStatR.EventReceiver.Hubs
{
   public class RecordStatsHub : Hub
    {
       public void IncrementCount(string key)
       {
           Console.WriteLine("event received");
           //process

           //pulse - should be called by an async worker
           var context = GlobalHost.ConnectionManager.GetHubContext<StatsListenerHub>();
           context.Clients.All.incrementedKeyUpdated(key, 1);
       }
    }
}

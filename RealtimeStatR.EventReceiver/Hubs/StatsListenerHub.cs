using Microsoft.AspNet.SignalR;
using System;

namespace RealtimeStatR.EventReceiver.Hubs
{
    public class StatsListenerHub : Hub
    {
        public void IncrementedKeyOutput(string keyname, int value)
        {
            Clients.All.incrementedKeyUpdated(keyname, value);
        }

    }
}

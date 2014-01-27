using System;
using System.Threading;
using Microsoft.AspNet.SignalR;

namespace SyncTime.Infrastructure
{
    public class SyncTimeHub : Hub
    {
        private static Timer _timer;

        public SyncTimeHub()
        {
            if (_timer == null)
            {
                _timer = new Timer(state => TimerOnTick());
                _timer.Change(1000, 10000);
            }
        }

        public void Getdelta()
        {
            Clients.Caller.SendDataTime(DateTime.UtcNow.ToJavaScriptMilliseconds());
        }

        private void TimerOnTick()
        {
            Clients.All.SyncTime(DateTime.UtcNow.ToJavaScriptMilliseconds());
        }
    }
}
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRMasteryUdemy.Hubs
{
    public class ViewHub : Hub
    {
        public static int ViewCount { get; set; } = 0;

        public Task IncrementServerView()
        {
            ViewCount++;

            return Clients.All.SendAsync("incrementView", ViewCount);
        }
    }
}
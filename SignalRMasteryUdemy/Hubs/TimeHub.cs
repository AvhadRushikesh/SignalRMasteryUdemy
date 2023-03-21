using Microsoft.AspNetCore.SignalR;

namespace SignalRMasteryUdemy.Hubs
{
    public class TimeHub : Hub
    {
        public async Task GetCurrentTime()
        {
            await Clients.Caller.SendAsync("UpdatedTime", DateTime.UtcNow.ToString("F"));
        }
    }
}
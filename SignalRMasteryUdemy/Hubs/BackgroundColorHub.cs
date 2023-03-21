using Microsoft.AspNetCore.SignalR;

namespace SignalRMasteryUdemy.Hubs
{
    public class BackgroundColorHub : Hub
    {
        public async Task ChangeBackground(string color)
        {
            await this.Clients.All.SendAsync("changeBackground", color);
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Data;

namespace SignalRMasteryUdemy.Hubs
{
    [Authorize()]
    public class ColorHub : Hub
    {
        [Authorize(Roles = "ADMIN")]
        public Task ChangeBackground(string color)
        {

            return Clients.All.SendAsync("changeBackground", color);
        }
    }
}

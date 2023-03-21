﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRMasteryUdemy.Hubs
{
    public class ViewHub : Hub<IHubClient>
    {
        public static int ViewCount { get; set; } = 0;

        public async Task NotifyWatching()
        {
            ViewCount++;

            //await this.Clients.All.SendAsync("viewCountUpdate", ViewCount);
            await this.Clients.All.ViewCountUpdate(ViewCount);
        }
    }

    public interface IHubClient
    {
        Task ViewCountUpdate(int viewCount);
    }
}
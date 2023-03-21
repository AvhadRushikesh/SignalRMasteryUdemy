using Microsoft.AspNetCore.SignalR;
using SignalRMasteryUdemy.Servives;

namespace SignalRMasteryUdemy.Hubs
{
    public class VoteHub : Hub
    {
        private readonly IVoteManager voteManager;
        private readonly ILogger<VoteHub> logger;

        public VoteHub(IVoteManager voteManager, ILogger<VoteHub> logger)
        {
            this.voteManager = voteManager;
            this.logger = logger;

            logger.LogDebug($"VoteHub created. {DateTime.UtcNow.ToLongTimeString()}");
        }

        public Dictionary<string, int> GetCurrentVotes()
        {
            return voteManager.GetCurrentVotes();
        }
    }
}
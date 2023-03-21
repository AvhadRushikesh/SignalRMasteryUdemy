using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRMasteryUdemy.Servives;

namespace SignalRMasteryUdemy.Controllers
{
    public class VoteController : ControllerBase
    {
        private readonly IVoteManager voteManager;

        public VoteController(IVoteManager voteManager)
        {
            this.voteManager = voteManager;
        }
        [HttpPost("/vote/pie")]
        public async Task<IActionResult> VotePie()
        {
            // save vote
            await voteManager.CastVote("pie");

            return Ok();
        }

        [HttpPost("/vote/bacon")]
        public async Task<IActionResult> VoteBacon()
        {
            // save vote
            await voteManager.CastVote("bacon");

            return Ok();
        }
    }
}

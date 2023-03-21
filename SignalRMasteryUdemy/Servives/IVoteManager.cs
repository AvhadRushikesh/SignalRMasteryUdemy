namespace SignalRMasteryUdemy.Servives
{
    public interface IVoteManager
    {
        Task CastVote(string voteFor);
        Dictionary<string, int> GetCurrentVotes();
    }
}
using Microsoft.AspNetCore.SignalR;

namespace SignalRMasteryUdemy.Hubs
{
    public class UserHub : Hub
    {
        private readonly IRandomUserService randomUserService;

        public UserHub(IRandomUserService randomUserService)
        {
            this.randomUserService = randomUserService;
        }
        public async Task<IEnumerable<RandomUser>> GetUsers(int max = 1)
        {
            var randomUsers = await randomUserService.GetUsers(max);

            return randomUsers;
        }
    }
}

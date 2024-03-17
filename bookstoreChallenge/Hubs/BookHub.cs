using Microsoft.AspNetCore.SignalR;

namespace bookstoreChallenge.app.Hubs
{
    public class BookHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            var response = $"Client ID: {Context.ConnectionId} conected";
            await Clients.Caller.SendAsync(response);
        }
    }
}

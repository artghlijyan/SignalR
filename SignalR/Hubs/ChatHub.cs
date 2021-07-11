using Microsoft.AspNetCore.SignalR;
using SignalR.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class ChatHub : Hub<IChatHub>
    {
        public async Task SendMessage(string model)
        {
            //await Clients.Others.ReceiveMessage(model);
        }
    }
}

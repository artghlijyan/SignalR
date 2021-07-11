using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using SignalR.Hubs;
using SignalR.Models;
using SignalR.Repo;
using SignalR.Repo.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalR.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ConversationController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private readonly IHubContext<ChatHub, IChatHub> _chatHubContext;

        public ConversationController(AppDbContext appDbContext, IHubContext<ChatHub, IChatHub> chatHubContext)
        {
            _appDbContext = appDbContext;
            _chatHubContext = chatHubContext;
        }

        [HttpGet]
        [Route("{model}")]
        public async Task<string> Ba([FromRoute] string model)
        {
            await _chatHubContext.Clients.All.ReceiveMessage(model);

            return "OK";
        }
    }
}

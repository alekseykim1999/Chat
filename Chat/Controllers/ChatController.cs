using Chat.Models;
using Chat.Service.ChatService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Controllers
{
    public class ChatController : Controller
    {

        private IChatService chatService;
        public ChatController(IChatService _chatService)
        {
            chatService = _chatService;
        }
      
        public ActionResult SendMessage()
        {
            chatService.SendMessage(new Message());
            return View();
        }

   
    }
}

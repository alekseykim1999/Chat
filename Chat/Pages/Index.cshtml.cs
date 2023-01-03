using Chat.Models;
using Chat.Service.ChatService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Chat.Pages
{
    public class IndexModel : PageModel
    {

        private IChatService chatService;
        public List<string> displayedMessages;
        public IndexModel(IChatService _chatService)
        {
            chatService = _chatService;
            displayedMessages = chatService.GetMessages();
            if(displayedMessages is null)
            {
                displayedMessages = new List<string>();
            }
        }


        public void OnPost(string text)
        {
            displayedMessages = chatService.SendMessage(text);
        }
    }
}
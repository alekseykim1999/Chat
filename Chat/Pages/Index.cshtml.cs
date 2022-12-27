using Chat.Models;
using Chat.Service.ChatService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Chat.Pages
{
    public class IndexModel : PageModel
    {

        private IChatService chatService;
        public List<Message> messages;
        public List<string> displayedMessages;

        public IndexModel(IChatService _chatService)
        {
            chatService = _chatService;
            messages = chatService.GetMessages();
            if(messages is null)
            {
                messages = new List<Message>();
            }
            displayedMessages = messages.Select(s => s.Text).ToList();
        }


        public void OnPost(string text)
        {
            chatService.SendMessage(text, ref displayedMessages);
        }
    }
}
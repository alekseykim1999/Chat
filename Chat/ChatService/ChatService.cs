using Chat.Models;
using Microsoft.EntityFrameworkCore;

namespace Chat.Service.ChatService
{
    public class ChatService : IChatService
    {
        private ChatContext db;
        private List<string> messages;
        public ChatService(ChatContext context)
        {
            db = context;
            messages = new List<string>();
        }

        public List<string> GetMessages()
        {
            messages = db.Messages.Select(s => s.Text).ToList();
            return messages;
        }


        public List<string> SendMessage(string _text)
        {
            Message mes = new Message() { SendTime = DateTime.Now, Text = _text };
            db.Messages.Add(mes);
            int sendMessages = db.SaveChanges();
            if (sendMessages > 0)
            {
                messages.Add(_text);
            }
            return messages;
        }
    }
}

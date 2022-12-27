using Chat.Models;
using Microsoft.EntityFrameworkCore;

namespace Chat.Service.ChatService
{
    public class ChatService : IChatService
    {
        private ChatContext db;
        public ChatService(ChatContext context)
        {
            db = context;
        }

        public List<Message> GetMessages()
        {
            var messages = db.Messages.ToList();
            return messages;
        }


        public int SendMessage(string _text, ref List<string> _displayedMessages)
        {
            Message mes = new Message() { SendTime = DateTime.Now, Text = _text };
            db.Messages.Add(mes);
            int sendMessages = db.SaveChanges();
            if (sendMessages > 0)
            {
                _displayedMessages.Add(_text);
            }
            return sendMessages;
        }
    }
}

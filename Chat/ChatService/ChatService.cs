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


        public int SendMessage(Message mes)
        {
            db.Messages.Add(mes);
            int sendMessages = db.SaveChanges();
            return sendMessages;
        }
    }
}

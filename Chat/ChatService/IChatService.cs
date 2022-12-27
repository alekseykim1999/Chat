using Chat.Models;
namespace Chat.Service.ChatService;
public interface IChatService
{
    public List<Message> GetMessages();
    public int SendMessage(Message mes);
}

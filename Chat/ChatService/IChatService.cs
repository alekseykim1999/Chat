using Chat.Models;
namespace Chat.Service.ChatService;
public interface IChatService
{
    public List<Message> GetMessages();
    public int SendMessage(string _text, ref List<string> _displayedMessages);
}

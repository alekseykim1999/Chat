using Chat.Models;
namespace Chat.Service.ChatService;
public interface IChatService
{
    public List<string> GetMessages();
    public List<string> SendMessage(string _text);
}

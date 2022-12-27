namespace Chat.Models
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime SendTime{ get; set; }
        public string? Text { get; set; } 
    }
}

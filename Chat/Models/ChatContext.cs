using Microsoft.EntityFrameworkCore;

namespace Chat.Models
{
    public class ChatContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public ChatContext (DbContextOptions<ChatContext> options)
            : base(options)
        {
            Database.EnsureCreated();  
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace ChatApp.Api.Models
{
    public class MessageReaction
    {
        public int Id { get; set; }
        
        [Required]
        public int MessageId { get; set; }
        public Message Message { get; set; } = null!;
        
        [Required]
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        
        [Required]
        [StringLength(10)]
        public string Emoji { get; set; } = string.Empty;
        
        public DateTime CreatedAt { get; set; }
    }
}
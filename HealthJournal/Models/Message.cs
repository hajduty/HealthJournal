using System.ComponentModel.DataAnnotations;

namespace HealthJournal.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public User Receiver { get; set; }
        public User Sender { get; set; }
        public string Info { get; set; }
        public DateTime Date { get; set; }
    }
}

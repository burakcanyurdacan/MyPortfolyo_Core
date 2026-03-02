namespace MyPortfolyo_Core.DAL.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string Mail { get; set; }
        public string MessageDetail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
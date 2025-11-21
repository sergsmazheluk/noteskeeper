namespace Notes.Domain
{
    public class Note
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Title { get; set; } = null!;
        public string Details { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}

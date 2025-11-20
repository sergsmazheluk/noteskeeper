namespace Notes.Domain
{
    public class Note
    {
        public Guid Userid { get; set; }
        public Guid Noteid { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}

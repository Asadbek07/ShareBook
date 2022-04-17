namespace Domain.Models.Book
{
    public class Book : BaseModel
    {
        public string Title { get; set; }
        public string ISBN { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Guid AuthorId { get; set; }
    }
}

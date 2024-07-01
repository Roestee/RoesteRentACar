namespace RoesteRentACar.Domain.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string BackgroundImageUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual Author Author { get; set; }
        public virtual Category Category { get; set; }
    }
}

namespace RoesteRentACar.Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public virtual List<Blog> Blogs { get; set; }
    }
}

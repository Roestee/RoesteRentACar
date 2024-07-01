namespace RoesteRentACar.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<Blog> Blogs { get; set; }
    }
}

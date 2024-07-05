namespace RoesteRentACar.Domain.Entities
{
    public class TagCloud
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; }
        public virtual Blog Blog { get; set; }
    }
}

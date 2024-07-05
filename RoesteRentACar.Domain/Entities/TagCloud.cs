namespace RoesteRentACar.Domain.Entities
{
    public class TagCloud
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int Title { get; set; }
        public virtual Blog Blog { get; set; }
    }
}

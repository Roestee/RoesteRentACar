namespace RoesteRentACar.Dto.BlogDtos
{
    public class ResultBlogWithDetailDto
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string BackgroundImageUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
    }
}

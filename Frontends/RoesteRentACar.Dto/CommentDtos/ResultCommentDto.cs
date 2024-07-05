namespace RoesteRentACar.Dto.CommentDtos
{
    public class ResultCommentDto
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
    }
}

using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Results.BlogResults
{
    public class GetBlogWithDetailWithCountQueryResult
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string BackgroundImageUrl { get; set; }
        public DateTime CreateDate { get; set; }
        public string AuthorName { get; set; }
    }
}

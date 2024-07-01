﻿using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.BlogCommands
{
    public class UpdateBlogCommand : IRequest
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string BackgroundImageUrl { get; set; }
        public DateTime CreateDate { get; set; }
    }
}

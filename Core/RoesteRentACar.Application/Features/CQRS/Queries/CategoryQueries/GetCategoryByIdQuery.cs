﻿namespace RoesteRentACar.Application.Features.CQRS.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery
    {
        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}

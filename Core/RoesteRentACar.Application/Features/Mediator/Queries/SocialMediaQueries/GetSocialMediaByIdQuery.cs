using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.SocialMediaResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIdQuery: IRequest<GetSocialMediaByIdQueryResult>
    {
        public GetSocialMediaByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}

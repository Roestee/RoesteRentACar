using MediatR;
using RoesteRentACar.Application.Features.Mediator.Results.SocialMediaResults;

namespace RoesteRentACar.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaQuery: IRequest<List<GetSocialMediaQueryResult>>
    {
    }
}

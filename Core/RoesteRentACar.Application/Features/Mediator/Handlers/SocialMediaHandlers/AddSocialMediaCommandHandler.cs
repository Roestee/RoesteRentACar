using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.SocialMediaCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class AddSocialMediaCommandHandler: IRequestHandler<AddSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;

        public AddSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new SocialMedia
            {
                Name = request.Name,
                Icon = request.Icon,
                Url = request.Url
            }, cancellationToken);
        }
    }
}

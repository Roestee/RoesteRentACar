using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.SocialMediaCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class UpdateSocialMediaCommandHandler: IRequestHandler<UpdateSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;

        public UpdateSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateSocialMediaCommand request, CancellationToken cancellationToken)
        {
            var socialMedia = await _repository.GetByIdAsync(request.Id, cancellationToken);
            socialMedia.Icon = request.Icon;
            socialMedia.Name = request.Name;
            socialMedia.Url = request.Url;

            await _repository.UpdateAsync(socialMedia, cancellationToken);
        }
    }
}

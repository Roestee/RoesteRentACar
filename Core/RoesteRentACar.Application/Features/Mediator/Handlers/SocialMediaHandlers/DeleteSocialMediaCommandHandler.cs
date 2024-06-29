using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.SocialMediaCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.SocialMediaHandlers
{
    public class DeleteSocialMediaCommandHandler: IRequestHandler<DeleteSocialMediaCommand>
    {
        private readonly IRepository<SocialMedia> _repository;

        public DeleteSocialMediaCommandHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteSocialMediaCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(request.Id, cancellationToken), cancellationToken);
        }
    }
}

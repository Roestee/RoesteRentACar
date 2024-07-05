using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.TagCloudCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class UpdateTagCloudCommandHandler: IRequestHandler<UpdateTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public UpdateTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTagCloudCommand request, CancellationToken cancellationToken)
        {
            var tagCloud = await _repository.GetByIdAsync(request.Id, cancellationToken);
            tagCloud.BlogId = request.BlogId;
            tagCloud.Title = request.Title;

            await _repository.UpdateAsync(tagCloud, cancellationToken);
        }
    }
}

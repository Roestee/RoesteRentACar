using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.TagCloudCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.TagCloudHandlers
{
    public class DeleteTagCloudCommandHandler: IRequestHandler<DeleteTagCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public DeleteTagCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteTagCloudCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(request.Id, cancellationToken),
                cancellationToken);
        }
    }
}

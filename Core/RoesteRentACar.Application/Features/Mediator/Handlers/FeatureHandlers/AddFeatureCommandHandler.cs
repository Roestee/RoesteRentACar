using MediatR;
using RoesteRentACar.Application.Features.Mediator.Commands.FeatureCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class AddFeatureCommandHandler : IRequestHandler<AddFeatureCommand>
    {
        private readonly IRepository<Feature> _repository;

        public AddFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(AddFeatureCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(new Feature { Name = request.Name }, cancellationToken);
        }
    }
}

using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.FeatureCommands
{
    public class DeleteFeatureCommand : IRequest
    {
        public DeleteFeatureCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}

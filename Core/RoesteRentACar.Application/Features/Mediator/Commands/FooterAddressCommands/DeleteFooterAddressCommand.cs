using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class DeleteFooterAddressCommand: IRequest
    {
        public DeleteFooterAddressCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}

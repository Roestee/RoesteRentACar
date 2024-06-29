﻿using MediatR;

namespace RoesteRentACar.Application.Features.Mediator.Commands.FooterAddressCommands
{
    public class AddFooterAddressCommand : IRequest
    {
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}

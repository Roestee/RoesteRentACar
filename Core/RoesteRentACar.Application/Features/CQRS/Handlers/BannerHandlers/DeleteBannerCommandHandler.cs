﻿using RoesteRentACar.Application.Features.CQRS.Commands.BannerCommands;
using RoesteRentACar.Application.Interfaces;
using RoesteRentACar.Domain.Entities;

namespace RoesteRentACar.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class DeleteBannerCommandHandler
    {
        private readonly IRepository<Banner> _repository;

        public DeleteBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteBannerCommand command)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(command.Id));
        }
    }
}

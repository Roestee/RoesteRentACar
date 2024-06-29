﻿namespace RoesteRentACar.Application.Features.CQRS.Commands.CategoryCommands
{
    public class DeleteCategoryCommand
    {
        public DeleteCategoryCommand(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}
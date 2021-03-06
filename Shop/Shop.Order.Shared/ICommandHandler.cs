﻿namespace Shop.Order.Shared
{
    public interface ICommandHandler<T> where T : ICommand
    {
        void Handle(T command);
    }
}

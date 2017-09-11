using System;

namespace EmailInterfaces
{
    public interface IDispatcherService
    {
        void Dispatch(Action action);
    }
}
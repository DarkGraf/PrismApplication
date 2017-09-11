using EmailInterfaces;
using System;
using System.Windows.Threading;

namespace EmailClient
{
    public class UIDispatcher : IDispatcherService
    {
        Dispatcher dispatcher;

        public UIDispatcher(Dispatcher dispatcher)
        {
            this.dispatcher = dispatcher;
        }

        public void Dispatch(Action action)
        {
            dispatcher.BeginInvoke(action);
        }
    }
}
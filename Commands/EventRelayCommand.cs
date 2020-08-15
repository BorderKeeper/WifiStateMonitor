using System;
using System.Windows.Input;

namespace WiFiStateMonitor.Commands
{
    public class EventRelayCommand : ICommand
    {
        private readonly EventHandler _execute;
        private readonly Predicate<object> _canExecute;

        public EventRelayCommand(EventHandler execute)
            : this(execute, null)
        {
        }

        public EventRelayCommand(EventHandler execute, Predicate<object> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameters)
        {
            return _canExecute == null || _canExecute(parameters);
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public void Execute(object parameters)
        {
            _execute?.Invoke(this, EventArgs.Empty);
        }
    }
}
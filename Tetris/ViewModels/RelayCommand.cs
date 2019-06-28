using System;
using System.Windows.Input;

namespace Tetris.ViewModels
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> execute;
        private readonly Func<object, bool> canExecute;
        private event EventHandler canExecuteChangedInternal;

        public static Func<object, bool> defaultCanExecute = (parameter) => true;

        public RelayCommand(Action<object> executeAction) : this(executeAction, defaultCanExecute) { }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute)
        {
            this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
            this.canExecute = canExecute ?? throw new ArgumentNullException(nameof(canExecute));
        }

        public bool CanExecute(object parameter) => canExecute(parameter);

        public void Execute(object parameter) => execute.Invoke(parameter);

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
                canExecuteChangedInternal += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
                canExecuteChangedInternal -= value;
            }
        }

        public void RaiseCanExecuteChanged() => canExecuteChangedInternal?.Invoke(this, EventArgs.Empty);
    }
}

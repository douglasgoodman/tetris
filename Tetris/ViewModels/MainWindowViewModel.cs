using System.Windows.Input;

namespace Tetris.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand StartCommand { get; }

        public MainWindowViewModel()
        {
            StartCommand = new RelayCommand(ExecuteStartCommand, CanExecuteStartCommand);
        }

        private bool CanExecuteStartCommand(object parameter) => true;

        private void ExecuteStartCommand(object parameter)
        {
            Text = "I clicked start!";
        }

        private string text = "Hi Bunny Rabbit!!!";
        public string Text
        {
            get => text;
            set => Set(ref text, value);
        }
    }
}

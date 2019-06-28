using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tetris.ViewModels;

namespace Tetris.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ISampleService sampleService;
        private readonly AppSettings settings;

        public MainWindow(
            ISampleService sampleService,
            IOptions<AppSettings> settings,
            MainWindowViewModel viewModel)
        {
            InitializeComponent();

            this.sampleService = sampleService;
            this.settings = settings.Value;
            this.DataContext = viewModel;
        }
    }
}

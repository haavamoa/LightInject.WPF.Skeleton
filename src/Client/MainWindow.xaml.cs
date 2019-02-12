using Client.ViewModels;

namespace Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow(IShellViewModel shellViewModel)
        {
            InitializeComponent();
            DataContext = shellViewModel;
            Loaded += async (e, a) => await shellViewModel.Initialize();
        }
    }
}
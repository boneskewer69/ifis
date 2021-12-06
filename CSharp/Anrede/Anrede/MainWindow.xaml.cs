using System.Windows;

namespace Anrede
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = SalutationViewModel.Singleton;
            ((SalutationViewModel)DataContext).RegisterObserver(new History());
        }
    }
}

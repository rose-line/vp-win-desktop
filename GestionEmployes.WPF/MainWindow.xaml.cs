using GestionEmployes.DataAccess;
using GestionEmployes.ViewModels;
using System.Windows;

namespace GestionEmployes.WPF
{
  public partial class MainWindow : Window
  {
    private MainViewModel _viewModel;

    public MainWindow()
    {
      InitializeComponent();

      _viewModel = new MainViewModel(new EmployeDataProvider());
      DataContext = _viewModel;

      Activated += MainWindow_Activated;
    }

    private void MainWindow_Activated(object sender, System.EventArgs e)
    {
      _viewModel.Charger();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {

    }
  }
}

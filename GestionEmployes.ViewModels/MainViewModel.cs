using GestionEmployes.Common.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GestionEmployes.ViewModels
{
  public class MainViewModel : ViewModelBase
  {
    private EmployeViewModel employeSelectionne;
    private IEmployeDataProvider _employeDataProvider;

    public MainViewModel(IEmployeDataProvider employeDP)
    {
      _employeDataProvider = employeDP;
      Employes = new();
    }

    public ObservableCollection<EmployeViewModel> Employes { get; }

    public EmployeViewModel EmployeSelectionne
    {
      get => employeSelectionne;
      set
      {
        if (employeSelectionne != value)
        {
          employeSelectionne = value;
          RaisePropertyChanged();
        }
      }
    }

    public void Charger()
    {
      var employes = _employeDataProvider.ChargerEmployes();

      Employes.Clear();
      foreach (var employe in employes)
      {
        Employes.Add(new EmployeViewModel(employe, _employeDataProvider));
      }
    }
  }
}

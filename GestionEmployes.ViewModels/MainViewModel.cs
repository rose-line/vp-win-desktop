using GestionEmployes.Common.Interfaces;
using GestionEmployes.Common.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

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
    public ObservableCollection<Role> Roles { get; } = new();

    public EmployeViewModel EmployeSelectionne
    {
      get => employeSelectionne;
      set
      {
        if (employeSelectionne != value)
        {
          employeSelectionne = value;
          RaisePropertyChanged();
          RaisePropertyChanged(nameof(PeutAfficherDetails));
        }
      }
    }

    public bool PeutAfficherDetails => EmployeSelectionne != null;

    public void Charger()
    {
      var employes = _employeDataProvider.ChargerEmployes();
      var roles = _employeDataProvider.ChargerRoles();

      Employes.Clear();
      foreach (var employe in employes)
      {
        Employes.Add(new EmployeViewModel(employe, _employeDataProvider));
      }

      Roles.Clear();
      foreach (var jobRole in roles)
      {
        Roles.Add(jobRole);
      }
    }
  }
}

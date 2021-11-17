using GestionEmployes.DataAccess;
using GestionEmployes.ViewModels;
using System.Windows.Forms;

namespace GestionEMployes.WinForms
{
  public partial class MainForm : Form
  {
    private MainViewModel _viewModel;

    public MainForm()
    {
      InitializeComponent();

      _viewModel = new MainViewModel(new EmployeDataProvider());
      
    }

    private void MainForm_Load(object sender, System.EventArgs e)
    {
      Charger();

      tbNom.DataBindings.Add("Text", bsEmployes, "Nom", false, DataSourceUpdateMode.OnPropertyChanged);
      tbPrenom.DataBindings.Add("Text", bsEmployes, "Prenom", false, DataSourceUpdateMode.OnPropertyChanged);
      dtpDateEmbauche.DataBindings.Add("Value", bsEmployes, "DateEmbaucheWPF");

      comboRole.DataSource = _viewModel.Roles;
      comboRole.DisplayMember = "Nom";
      comboRole.ValueMember = "Id";
      comboRole.DataBindings.Add("SelectedValue", bsEmployes, "RoleId");

      checkPiloteDeLigne.DataBindings.Add("Checked", bsEmployes, "EstPiloteDeLigne");
    }

    private void btnRafraichir_Click(object sender, System.EventArgs e)
    {
      Charger();
      bsEmployes.ResetBindings(false);
    }

    private void Charger()
    {
      _viewModel.Charger();

      bsEmployes.DataSource = _viewModel.Employes;
      lbEmployes.DataSource = bsEmployes;
      lbEmployes.DisplayMember = "Nom";
    }

    private void btnSauvegarder_Click(object sender, System.EventArgs e)
    {
      var vmCourant = bsEmployes.Current as EmployeViewModel;
      vmCourant.Sauvegarder();
    }
  }
}

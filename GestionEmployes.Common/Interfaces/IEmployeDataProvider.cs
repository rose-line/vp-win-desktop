using GestionEmployes.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmployes.Common.Interfaces
{
  public interface IEmployeDataProvider
  {
    IEnumerable<Employe> ChargerEmployes();
    void SauvegarderEmploye(Employe employe);
    IEnumerable<Role> ChargerRoles();
  }
}

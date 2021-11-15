using System;

namespace GestionEmployes.Common.Model
{
  public class Employe
  {
    public int Id { get; set; }

    public string Prenom { get; set; }

    public string Nom { get; set; }

    public DateTimeOffset DateEmbauche { get; set; }

    public bool EstPiloteDeLigne { get; set; }

    public int RoleId { get; set; }

  }

}


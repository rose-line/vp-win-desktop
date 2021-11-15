using GestionEmployes.Common.Interfaces;
using GestionEmployes.Common.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace GestionEmployes.DataAccess
{
  public class EmployeDataProvider : IEmployeDataProvider
  {
    public IEnumerable<Employe> ChargerEmployes()
    {
      IEnumerable<Employe> res;

      res = new List<Employe>()
      {
        new Employe
        {
          Id = 1,
          Prenom = "Roger",
          Nom = "Cageot",
          DateEmbauche = new DateTime(2021, 10, 15),
          EstPiloteDeLigne = false,
          RoleId = 4
        },
        new Employe
        {
          Id = 2,
          Prenom = "Bruce",
          Nom = "Dickinson",
          DateEmbauche = new DateTime(1981, 9, 15),
          EstPiloteDeLigne = true,
          RoleId = 1
        },
        new Employe
        {
          Id = 3,
          Prenom = "Dave",
          Nom = "Murray",
          DateEmbauche = new DateTime(2020, 1, 1),
          EstPiloteDeLigne = true,
          RoleId = 2
        },
        new Employe
        {
          Id = 4,
          Prenom = "Steve",
          Nom = "Harris",
          DateEmbauche = new DateTime(2013, 5, 15),
          EstPiloteDeLigne = true,
          RoleId = 3
        },
        new Employe
        {
          Id = 5,
          Prenom = "Adrian",
          Nom = "Smith",
          DateEmbauche = new DateTime(2014, 11, 17),
          EstPiloteDeLigne = true,
          RoleId = 2
        }
      };

      return res;
    }

    public IEnumerable<Role> ChargerRoles()
    {
      return new List<Role>
      {
        new Role { Id = 1, Nom = "Chanteur"},
        new Role { Id = 2, Nom = "Guitariste"},
        new Role { Id = 3, Nom = "Bassiste"},
        new Role { Id = 4, Nom = "Batteur"},
      };
    }

    public void SauvegarderEmploye(Employe employe)
    {
      Debug.WriteLine($"Employé sauvegardé : {employe.Nom}");
    }
  }
}

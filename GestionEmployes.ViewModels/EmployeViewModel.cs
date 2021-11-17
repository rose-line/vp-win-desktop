﻿using GestionEmployes.Common.Interfaces;
using GestionEmployes.Common.Model;
using System;

namespace GestionEmployes.ViewModels
{
  public class EmployeViewModel : ViewModelBase
  {
    private Employe _employe;
    private IEmployeDataProvider _employeDataProvider;

    public EmployeViewModel(Employe employe, IEmployeDataProvider employeDP)
    {
      _employe = employe;
      _employeDataProvider = employeDP;
    }

    public string Prenom
    {
      get => _employe.Prenom;
      set
      {
        if (_employe.Nom != value)
        {
          _employe.Prenom = value;
          RaisePropertyChanged();
          RaisePropertyChanged(nameof(PeutSauvegarder));
        }
      }
    }

    public string Nom
    {
      get => _employe.Nom;
      set
      {
        if (_employe.Prenom != value)
        {
          _employe.Nom = value;
          RaisePropertyChanged();
          RaisePropertyChanged(nameof(PeutSauvegarder));
        }
      }
    }

    public DateTimeOffset DateEmbauche
    {
      get => _employe.DateEmbauche;
      set
      {
        if (_employe.DateEmbauche != value)
        {
          _employe.DateEmbauche = value;
          RaisePropertyChanged();
        }
      }
    }

    public int RoleId
    {
      get => _employe.RoleId;
      set
      {
        if (_employe.RoleId != value)
        {
          _employe.RoleId = value;
          RaisePropertyChanged();
        }
      }
    }

    public bool EstPiloteDeLigne
    {
      get => _employe.EstPiloteDeLigne;
      set
      {
        if (_employe.EstPiloteDeLigne != value)
        {
          _employe.EstPiloteDeLigne = value;
          RaisePropertyChanged();
        }
      }
    }

    public bool PeutSauvegarder => !string.IsNullOrWhiteSpace(Prenom)
                                    && !string.IsNullOrWhiteSpace(Nom);

    public void Sauvegarder()
    {
      _employeDataProvider.SauvegarderEmploye(_employe);
    }
  }
}

using FTRC.Data;
using FTRC.Systems.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FTRC.ViewModels
{
    public class RegimenViewModel : ViewableObject
    {
        public ObservableCollection<ExcerciseViewModel> Excercises { get; set; }
        private Regimen Regimen { get; set; }

        public RegimenViewModel(Regimen regimen)
        {
            Regimen = regimen;
        }

        public RegimenViewModel()
        {
            Initialize();
        }

        private void Initialize()
        {
            var injectedState = DISystem.PendingDependencies.Peek();
            if (injectedState != null && injectedState is int)
            {
                //InitializeKC
            }
            else
            {
                InitializeNew();
            }
        }

        private void InitializeNew()
        {
            Excercises = new ObservableCollection<ExcerciseViewModel>();
        }
    }
}

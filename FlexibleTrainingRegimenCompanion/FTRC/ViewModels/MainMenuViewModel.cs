using FTRC.Data;
using FTRC.Repositories;
using FTRC.Systems.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FTRC.ViewModels
{
    public class MainMenuViewModel : ViewableObject
    {
        public ObservableCollection<RegimenViewModel> Regimens { get; set; }
        public ICommand EditRegimenCommand { get; set; }
        public ICommand AddRegimenCommand { get; set; }

        public MainMenuViewModel()
        {
            InitializeCommands();
            Repopulate();
        }

        private void InitializeCommands()
        {
            EditRegimenCommand = new Command(OnEditRegimenCommand);
            AddRegimenCommand = new Command(OnAddNewRegimenCommand);
        }

        private void OnEditRegimenCommand(object obj)
        {
            DISystem.PendingDependencies.Enqueue(obj);
        }

        private void OnAddNewRegimenCommand(object obj)
        {
            Regimens.Add(new RegimenViewModel(RegimenRepository.Instance.Add()));
        }

        private void Repopulate()
        {
            Regimens = new ObservableCollection<RegimenViewModel>(RegimenRepository.Instance.GetAll()
                .Select((x) => new RegimenViewModel(x)));
            //NotifyPropertyChanged("Regimens");
        }
    }
}

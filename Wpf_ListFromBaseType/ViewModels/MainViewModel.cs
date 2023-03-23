using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_ListFromBaseType.Commands;
using Wpf_ListFromBaseType.Models;

namespace Wpf_ListFromBaseType.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public ObservableCollection<Animal> Animals { get; set; } = new ObservableCollection<Animal>();
        public Animal SelectedAnimal
        {
            get { return _selectedAnimal; }
            set
            {
                _selectedAnimal = value;
                OnPropertyChanged(nameof(SelectedAnimal));
            }
        }

        private Animal _selectedAnimal;

        public ICommand Cmd_Remove_SelectedAnimal => _cmd_Remove_SelectedAnimal ?? (_cmd_Remove_SelectedAnimal = new RelayCommand(RemoveSelectedAnimal, RemoveSelectedAnimal_CanExecute));
        public ICommand Cmd_Add_Dog => _cmd_Add_Dog ?? (_cmd_Add_Dog = new RelayCommand(AddDog, AddDog_CanExecute));
        public ICommand Cmd_Add_Cat => _cmd_Add_Cat ?? (_cmd_Add_Cat = new RelayCommand(AddCat, AddCat_CanExecute));

        private ICommand _cmd_Remove_SelectedAnimal;
        private ICommand _cmd_Add_Dog;
        private ICommand _cmd_Add_Cat;


        public MainViewModel()
        {

        }

        private bool RemoveSelectedAnimal_CanExecute(object parameter) => SelectedAnimal != null;
        private void RemoveSelectedAnimal(object paraemter) => Animals.Remove(SelectedAnimal);

        private bool AddDog_CanExecute(object parameter) => true;
        private void AddDog(object parameter) => Animals.Add(new Dog("John Dawg", "Stray Dog"));

        private bool AddCat_CanExecute(object parameter) => true;
        private void AddCat(object parameter) => Animals.Add(new Cat("Zyzlack", "House Cat"));

        protected virtual void OnPropertyChanged(string propName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}

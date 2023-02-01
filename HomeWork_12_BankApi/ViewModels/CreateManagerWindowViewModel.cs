using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using HomeWork_12_BankApi.Class;
using HomeWork_12_BankApi.Views;

namespace HomeWork_12_BankApi.ViewModels
{
    public class CreateManagerWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public CreateManagerWindowViewModel(ManagerWindow managerWindow)
        {
            ManagerWindow = managerWindow;
        }

        ManagerWindow ManagerWindow { get; set; }
        AppContextDb db;
        private string _name;
        private string _patranomic;
        private string _surname;

        #region Property
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Patranomic
        {
            get => _patranomic;
            set
            {
                _patranomic = value;
                OnPropertyChanged("Patranomic");
            }
        }
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                OnPropertyChanged("Surname");
            }
        }
        #endregion Property

        #region Comands
        DelegateCommand _createManager;
        public DelegateCommand CreateManager
        {
            get
            {
                return _createManager ??
                    (_createManager = new DelegateCommand(obj =>
                    {
                        if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Patranomic) || string.IsNullOrEmpty(Surname))
                        {
                            MessageBox.Show("Все поля должны быть заполненны");
                        }
                        else
                        {
                            Manager manager = new Manager(Name, Patranomic, Surname);
                            db = new AppContextDb();
                            db.Manager.Add(manager);
                            db.SaveChanges();

                            ManagerWindow.Close();
                        }
                    }));
            }
        } 
        #endregion
    }
}

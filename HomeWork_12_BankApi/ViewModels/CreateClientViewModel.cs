using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HomeWork_12_BankApi.Class;
using HomeWork_12_BankApi.Views;

namespace HomeWork_12_BankApi.ViewModels
{
    public class CreateClientViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public CreateClientViewModel (CreateClientWindow createClientWindow)
        {
            CreateClientWindow = createClientWindow;
        }

        AppContextDb db;
        CreateClientWindow CreateClientWindow { get; set; }

        string _name;
        string _patronomic;
        string _surname;
        DateTime _dateOfBirth;
        string _phoneNumber;
        string _status;
        CreateClientWindow ClientWindow { get; set; }

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
        public string Patronomic
        {
            get => _patronomic;
            set
            {
                _patronomic = value;
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
        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                _dateOfBirth = value;
                OnPropertyChanged("DateOfBirth");
            }
        }
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged("PhoneNumber");
            }
        }
        public string Status
        {
            get => _status;
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
        #endregion Prioerty

        DelegateCommand _createClient;
        public DelegateCommand CreatecreateClient
        {
            get
            {
                return _createClient ??
                    (_createClient = new DelegateCommand(obj =>
                    {
                        if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Patronomic) || string.IsNullOrEmpty(Surname)
                            || string.IsNullOrEmpty(PhoneNumber) || string.IsNullOrEmpty(Status) || DateOfBirth == null)
                        {
                            MessageBox.Show("Все поля должны быть заполненны");
                        }
                        else
                        {
                            Client client = new Client(Name,Patronomic,Surname,DateOfBirth,PhoneNumber,Status);
                            db = new AppContextDb();
                            db.Client.Add(client);
                            db.SaveChanges();

                            CreateClientWindow.Close();
                        }
                    }));
            }

        }
    }
}

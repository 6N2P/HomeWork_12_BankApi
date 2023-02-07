using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using HomeWork_12_BankApi.Class;
using HomeWork_12_BankApi.Views;
namespace HomeWork_12_BankApi.ViewModels


{
    public class CreateBankAccountViewModel : INotifyPropertyChanged
    {
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

        public CreateBankAccountViewModel() { }
        public CreateBankAccountViewModel (CreateBankAccountWindow createBankAccountWindow)
        {           
            LoadClients();
            LoadManagers();
            SelectDeposit = 0;
        }

        AppContextDb db;        

        int _selectClient;
        int _accountAmount;
        int _selectDeposit;
        int _selectManager;

        List<Client> _clients;
        List<Manager> _managers;

        #region Property
        CreateBankAccountWindow createBankAccountWindow { get; set; }
        public List<Client> Clients
        {
            get => _clients;
            set
            {
                _clients = value;
                OnPropertyChanged("Clients");
            }
        }

        public List<Manager> Managers
        {
            get => _managers;
            set
            {
                _managers = value;
                OnPropertyChanged("Managers");
            }
        }
        public int SelectClient
        {
            get => _selectClient;
            set
            {
                _selectClient = value;
                OnPropertyChanged("SelectClient");
            }
        }
        public int AccountAmount
        {
            get => _accountAmount;
            set
            {
                _accountAmount = value;
                OnPropertyChanged("AccountAmount");
            }
        }
        public int SelectDeposit
        {
            get => _selectDeposit;
            set
            {
                _selectDeposit = value;
                OnPropertyChanged("SelectDeposit");
            }
        }
        public int SelectManager
        {
            get => _selectManager;
            set
            {
                _selectManager = value;
                OnPropertyChanged("SelectManager");
            }
        }
        #endregion Property

        DelegateCommand _createBankAccount;
        public DelegateCommand CreateBankAccount
        {
            get
            {
                return _createBankAccount ??
                    (_createBankAccount = new DelegateCommand(obj =>
                    {
                        db = new AppContextDb();
                        //получить ид клиента
                        Client client = Clients[SelectClient];
                        //получить ид менеджера
                        Manager manager = Managers[SelectManager];
                        //создать банковкий счет
                        BankAccount bankAccount = new BankAccount(client, AccountAmount, SelectDeposit, true, manager);
                        db.BankAccount.Add(bankAccount);
                        db.SaveChanges();

                    }));
            }
        }

        void LoadClients()
        {
            db = new AppContextDb();
            db.Client.Load();
            Clients = db.Client.ToList();
        }
      
        void LoadManagers()
        {
            db = new AppContextDb();
            db.Manager.Load();
            Managers = db.Manager.ToList();
        }
      

    }
}

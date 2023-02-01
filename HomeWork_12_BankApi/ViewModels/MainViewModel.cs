using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using HomeWork_12_BankApi.Views;

namespace HomeWork_12_BankApi.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        #region Comands
        DelegateCommand _showCreateManagerWindow;
        public DelegateCommand ShowCreateManagerWindow
        {
            get
            {
                return _showCreateManagerWindow ??
                    (_showCreateManagerWindow = new DelegateCommand(obj =>
                    {
                        ManagerWindow createManagerWindow = new ManagerWindow();
                        createManagerWindow.ShowDialog();
                    }));
            }
        }
        DelegateCommand _showCreateClientWindow;
        public DelegateCommand ShowCreateClientWindow
        {
            get
            {
                return _showCreateClientWindow ??
                    (_showCreateClientWindow = new DelegateCommand(obj =>
                    {
                        CreateClientWindow createClientWindow = new CreateClientWindow();
                        createClientWindow.ShowDialog();
                    }));
            }
        }
        DelegateCommand _showCreateBankAccountWindow;
        public DelegateCommand ShowCreateBankAccountWindow
        {
            get
            {
                return _showCreateBankAccountWindow ??
                    (_showCreateBankAccountWindow = new DelegateCommand(obj =>
                    {
                        CreateBankAccountWindow createBankAccountWindow = new CreateBankAccountWindow();
                        createBankAccountWindow.ShowDialog();
                    }
                    ));
            }
        }
        #endregion Comands

    }
}

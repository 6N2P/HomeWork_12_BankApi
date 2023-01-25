using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using HomeWork_12_BankApi.Class;
using System.Data.SQLite;
using System.Data.Entity;

namespace HomeWork_12_BankApi.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppContextDb db;
        public MainWindow()
        {
            InitializeComponent();
            db = new AppContextDb();
            db.Manager.Load();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            Manager manager = new Manager("Менеджер","Менеджерович","Менеджоров");
            db.Manager.Add(manager);
            db.SaveChanges();
            //Client client = new Client("Василий", "Давыдович", "Чпонькин", DateTime.Now, "89199199999", 1);
            //db.Clients.Add(client);
            //db.SaveChanges();
            //BankAccount bankAccount = new BankAccount(client,6000,true,true,manager);
          
            //db.BankAccounts.Add(bankAccount);
            //db.SaveChanges();
            
            
        }
    }
}

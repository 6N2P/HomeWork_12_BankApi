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

using HomeWork_12_BankApi.ViewModels;
using HomeWork_12_BankApi.Class;


namespace HomeWork_12_BankApi.Views
{
    /// <summary>
    /// Логика взаимодействия для CreateBankAccountWindow.xaml
    /// </summary>
    public partial class CreateBankAccountWindow : Window
    {
        public CreateBankAccountWindow()
        {
            InitializeComponent();
            DataContext = new CreateBankAccountViewModel(this);

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void bt_Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_BankApi.Class
{
    public class BankAccount
    {
        public int ID { get; set; }
        /// <summary>
        /// Ид клиента
        /// </summary>
        public int ClientID { get; set; }
        /// <summary>
        /// Сумма на счете
        /// </summary>
        public int AccountAmount { get; set; }
        /// <summary>
        /// Депозитный-не депозитный счет
        /// </summary>
        public int IsDeposit { get; set; }
        /// <summary>
        /// Открытый или закрытый счёт
        /// </summary>
        public bool IsOpenAccount { get; set; }
        public int ManagerID { get; set; }

        public BankAccount() { }
        public BankAccount( Client clientID, int accountAmount, int isDeposit, bool isOpenAccount, Manager managerID)
        {
            
            ClientID = clientID.ID;
            AccountAmount = accountAmount;
            IsDeposit = isDeposit;
            IsOpenAccount = isOpenAccount;
            ManagerID = managerID.ID;
        }
    }
}

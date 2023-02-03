using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_BankApi.Class
{
    public class Client
    {
        public int ID { get; set; }
        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отчество клиента
        /// </summary>
        public string Patronymic { get; set; }
        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Дата рождения клиента
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Номер телефона клиента
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Статус вип клиент или ещё какой
        /// </summary>
        public string Status { get; set; }

        public Client() { }
        public Client( string name, string patronomic, string surname, DateTime dateOfBirth, string phoneNumber, string status)
        {
            
            Name = name;
            Patronymic = patronomic;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Status = status;
        }
    }
}

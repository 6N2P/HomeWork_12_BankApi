using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_12_BankApi.Class
{
    public class Manager
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Patranomic { get; set; }
        public string Surname { get; set; }

        public Manager() { }
        public Manager ( string name, string patranomic, string surname)
        {
            
            Name = name;
            Patranomic = patranomic;
            Surname = surname;
        }
    }
}

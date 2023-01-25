using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using System.Data.SQLite;

namespace HomeWork_12_BankApi.Class
{
    public class AppContextDb : DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<BankAccount> BankAccount { get; set; }


        public AppContextDb() : base("DefultConection") { }
    }
}

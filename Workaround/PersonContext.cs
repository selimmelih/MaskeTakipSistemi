using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    public class PersonContext : DbContext
    {
        //Burada Db Bağlantısını Yaptık. İnitialin içi boş geliyor onu ChatGpt den doldurduk yoksa tablo dbye düşmüyor.
        public DbSet<Person> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MaskeTakip;Integrated Security=True;");
            }
        }
    }

}

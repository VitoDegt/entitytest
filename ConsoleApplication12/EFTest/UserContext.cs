using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
   public class UserContext: DbContext
    {
        //private string _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public UserContext()
            
        {

        }

        public DbSet<User> Users { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            User user;




            using (var userContext = new UserContext())
            {
                user = userContext.Users.FirstOrDefault();
                Console.WriteLine(user);
            }
            using (var userContext1 = new UserContext())
            {
               
                //userContext1.Entry(user).State = EntityState.Modified;
                userContext1.Users.Attach(user).Age = 3000;

                userContext1.SaveChanges();
            }
        }              
    }
}


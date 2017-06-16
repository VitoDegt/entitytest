using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UserContext())
            {
                context.Users.Add(new User
                {
                    Name = "Tomas",
                    Age = 52,
                });

                context.SaveChanges();
            }
        }
    }
}

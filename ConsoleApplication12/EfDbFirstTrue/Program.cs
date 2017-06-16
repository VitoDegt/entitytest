using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDbFirstTrue
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new UserDBEntities())
            {
                context.Users.Add(new User
                {
                    Name = "Tomasik",
                    Age = 52,
                });

                context.SaveChanges();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new School_Context())
            {
                // Create a new student object
                var stud = new Student() { StudentName = "Eden" };

                // Add the new student to the students DbSet
                ctx.Students.Add(stud);

                // Save the changes to the database
                ctx.SaveChanges();
            }
        }
    }
}

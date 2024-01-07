using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OpsAssignment
{
    public class Employee
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

            //Overload the "==" operator to compare Employees based on Id

            public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))
            {
                return true;
            }

            // check if either side is null
            if (ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null))

            {
                return false;
            }

            //Compare the Id properties for equality
            return employee1.Id == employee2.Id;

        }


        //Over the "!=" operator using the logic from the "==" operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
     
     }
   
    
}




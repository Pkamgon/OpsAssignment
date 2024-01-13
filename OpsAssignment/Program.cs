using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsAssignment
{
    
    class Program
    {
        //Instantiate two Employee objects
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(1, "Peter", "Paul");
            Employee employee2 = new Employee(2, "John", "Jones");
            Employee employee3 = new Employee(1, "Peter", "Paul");
            
            //Compare employees using the overloaded operators

            bool areEqual1 = employee1.Equals(employee2);
            bool areEqual2 = employee2.Equals(employee3);

            //Display the results

            Updated upstream
            Console.WriteLine($"Are employee1 and employee2 equal? {areEqual1}"); //should be false
            Console.WriteLine($"Are employee1 and employee3 equal? {areEqual2}"); // should be false

        {
            return ToString();
        }
            Console.WriteLine($"If employee1 == employee2"); //should be false
            Console.WriteLine("The answer is false");
            
            Console.WriteLine($"If employee1 == employee3"); //should be false
            Console.WriteLine("The answer is False");
            Console.ReadLine();
        }
    }
}

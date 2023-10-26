using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)

        {
            IcustomerDal[] customerDals = new IcustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
            };
            
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();

            }



            Console.ReadLine();

            CustomerManager customerManager= new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());

            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Gökçe", LastName = "Fırat", Adress = "İstanbul" });

            Student student = new Student
            {
                Id = 1,
                FirstName = "Gökay",
                LastName = "Fırat",
                Department = "Computer Sciences"

            };


            manager.Add(student);
            
            
           
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }



    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }

    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName);

        }
    }
}


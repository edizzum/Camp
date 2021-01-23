using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ediz Züm
            Individual customer = new Individual();
            customer.Id = 1;
            customer.CustomerNo = "12345";
            customer.Name = "Ediz";
            customer.SurName = "Züm";
            customer.TcNo = "12345678910";

            //Kodlama.io
            Coorporate customer2 = new Coorporate();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            //Coorporate - Individual
            //SOLID

            Customer customer3 = new Individual();
            Customer customer4 = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }
    }
}

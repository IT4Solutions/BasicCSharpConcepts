using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpConcepts.Model
{
    public class Customer
    {
        
        // Data Members/ Properties / Fields
         public int CustomerID { get; set; }
         public string CustomerName { get; set; }
         public string Address { get; set; }
         public decimal Balance { get; set; }
         public bool IsCreditCustomer { get; set; }
         public bool IsMarried { get; set; }


        public static string CustomerNumber { get; set; }

        public static string ConnectionString()
        {
            return "Data Source = xyz";
        }

        // Constructor
        public Customer()
        {
            Console.WriteLine("Object Created");
        }

        // Methods / Functions
        private void GetInput()
        {

        }

        public void DisplayCustomer()
        {

        }

        public string GetCustomerName()
        {
            return this.CustomerName;
        }

        public int GetCustomerID()
        {
            return 60;
        }

        public void GetandDisplayCustomer(int customerID, string customerName)
        {
            Console.WriteLine("ID {0} And Name is {1}",customerID,customerName); 
        }

        public void GetandDisplayCustomer()
        {
            Console.WriteLine("Function 2");
        }

        public void GetandDisplayCustomer(int customerNumber)
        {
            Console.WriteLine("Function 3");
        }

        public void GetandDisplayCustomer(bool isMarried)
        {
            Console.WriteLine("Function 4");
        }
    }
}

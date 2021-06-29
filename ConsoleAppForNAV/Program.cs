using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForNAV
{
    using CustomerService;
    using LettersService;
  

    class Program
    {
        static void Main(string[] args)
        {

            // Create an instance of letters service
            MyLetters myLetters = new MyLetters();
           // myLetters.UseDefaultCredentials = true;
            Console.WriteLine(myLetters.Url);

            // Declare variables to work with
            string input, output;
            input = "Hello my good friend";

            // Call MS NAV codeunit web service
            output = myLetters.Capitalize(input);
            Console.WriteLine("Result: {0}", output);

            // keep console open
            Console.ReadLine();

           
            /*
            // Create instance of service and set credentials
            PageWithCapitalization_Service service = new PageWithCapitalization_Service();
            service.UseDefaultCredentials = true;
/*
            // Create instance of customer
            PageWithCapitalization cust = new PageWithCapitalization();
            cust.Name = "Ssenyo Gil";
            cust.Address = "Michigan Tower";

            // Insert customer using default operation
            service.Create(ref cust);
            Console.WriteLine("created customer " + cust.Name);

            // Calls extension codeunit to capitalize customer name
            // It takes the customer record as parameter
            service.CapitalizeName(cust.Key);

            // Refreshes customer
            cust = service.Read(cust.No);
 
            Console.WriteLine("Refreshed customer is " + cust.Name);
*/
            // delete created customer so this same code can be run again with no issues 
            /* bool isDeleted = service.Delete(cust.Key);
             Console.WriteLine("Deleted: " + isDeleted);

             cust = service.Read("C00040");
             service.Delete(cust.Key);
            */

            /*

            PageWithCapitalization_Filter filter = new PageWithCapitalization_Filter();
            filter.Field = PageWithCapitalization_Fields.Name;
            filter.Criteria = "SSE*";
            PageWithCapitalization_Filter[] filters = new PageWithCapitalization_Filter[] { filter };
            PageWithCapitalization[] customers = service.ReadMultiple(filters, null, 10);
            for(int i = 0;i < customers.Length; i++)
            {
                PageWithCapitalization c = customers[i];
                Console.WriteLine("Customer name is " + c.Name + " and address is " + c.Address);
            }

            */
         


        }
    }
}

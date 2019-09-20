using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList CustomerInfo = new System.Collections.ArrayList();

            CustomerInfo.Add(new CustomerInfo() { Name = "A", phonenumber = "B", mail = "C", favorit = "D" });

            foreach (CustomerInfo tot in CustomerInfo) 
            {
               Console.WriteLine("{0} {1} {2} {3}", tot.Name, tot.phonenumber, tot.mail, tot.favorit);
            }
        }
    }
}

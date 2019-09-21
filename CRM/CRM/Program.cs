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

            CustomerInfo.Add(new CustomerInfo() { Name = "Tony Stark", phonenumber = "0123456789", mail = "tony.stark@iron.man", favorit = "-" });
            CustomerInfo.Add(new CustomerInfo() { Name = "Steve Rodgers", phonenumber = "1800728693", mail = "captain@america.com", favorit = "Yes" });
            CustomerInfo.Add(new CustomerInfo() { Name = "Peter Parker", phonenumber = "9858484860", mail = "spider@man.de", favorit = "-" });
            CustomerInfo.Add(new CustomerInfo() { Name = "Bruce Wayne", phonenumber = "8618561627", mail = "batman@batmail.got", favorit = "Yes" });
            CustomerInfo.Add(new CustomerInfo() { Name = "Thor", phonenumber = "1800666999", mail = "thor@asgard.se", favorit = "Yes" });
            CustomerInfo.Add(new CustomerInfo() { Name = "Nick Fury", phonenumber = "1964879152", mail = "fury@shield.hd", favorit = "-" });

            bool cont = true;
            String instr;
            String again;
            while (cont == true) {
                Console.WriteLine("Ange namn");
                instr = Console.ReadLine();


                foreach (CustomerInfo tot in CustomerInfo)
                {
                    if (instr.Equals(tot.Name))
                    {
                        Console.WriteLine("{0} {1} {2} {3}", tot.Name, tot.phonenumber, tot.mail, tot.favorit);
                    }
                }
                Console.WriteLine("Tack, registrerad, mer? (Ja/Nej)");
                again = Console.ReadLine();
                if (again.Equals ("Nej"))
                {
                    cont = false;
                }
                    

            }
        }
    }
}

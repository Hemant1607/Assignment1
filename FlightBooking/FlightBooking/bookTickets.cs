using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightBooking
{
    class bookTickets
    {
        public static void TicketBooking()
        {
            FileStream fs = new FileStream(@"C:\Users\Hemanth Kumar\source\repos\FlightBooking\FlightBooking\bookingDeatils.txt", FileMode.Append, FileAccess.Write);
            StreamWriter ObjWrite = new StreamWriter(fs);
            Console.WriteLine("Enter number of passengers:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter details of passenger {0}:", (i + 1));
                Console.WriteLine("Enter name of passenger:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter age of passenger:");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter gender of passenger:");
                string gender = Console.ReadLine();
                Console.WriteLine("Enter source:");
                string source = Console.ReadLine();
                Console.WriteLine("Enter destination");
                string destination = Console.ReadLine();
                label: Console.WriteLine("Choose option of class you want to travel:\n1.First class2.Business class\n3.Economy class");
                int c = Convert.ToInt32(Console.ReadLine());
                string TravelClass="";
                if (c == 1)
                    TravelClass = "First class";
                else if (c == 2)
                    TravelClass = "Business class";
                else if (c == 3)
                    TravelClass = "Economy class";
                else
                {
                    Console.WriteLine("Please choose valid option!!");
                    goto label;
                }
                //ObjWrite.WriteLine("Passenger Details:");
                ObjWrite.WriteLine("Name:"+name);
                ObjWrite.WriteLine("Age:"+age);
                ObjWrite.WriteLine("Gender:"+gender);
                ObjWrite.WriteLine("Source:" + source);
                ObjWrite.WriteLine("Destination:" + destination);
                ObjWrite.WriteLine("Class:" + TravelClass);
                ObjWrite.WriteLine();

            }
            ObjWrite.Close();
            fs.Close();
        }
    }
}

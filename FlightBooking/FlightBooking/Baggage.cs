using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightBooking
{
    class Baggage
    {
        public static void BaggageDetails()
        {
            Console.WriteLine("Enter name of passenger:");
            string name = Console.ReadLine();
            FileStream fr = new FileStream(@"C:\Users\Hemanth Kumar\source\repos\FlightBooking\FlightBooking\bookingDeatils.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fr);
            sr.ReadLine();
            int temp = 0;
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                string[] details = line.Split(':');
                //Console.WriteLine(details[0]);
                if (String.Equals(details[1],name))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        sr.ReadLine();
                    }
                    line = sr.ReadLine();
                    details = line.Split(':');
                    temp = 1;
                    if(details[1]=="First class")
                    {
                        CostCal(50);
                    }
                    if (details[1] == "Business class")
                    {
                        CostCal(40);
                    }
                    if (details[1] == "Economy class")
                    {
                        CostCal(20);
                    }
                    break;
                }
                for (int i = 0; i < 6; i++)
                {
                    sr.ReadLine();
                }
            }
            if (temp == 0)
            {
                Console.WriteLine("Passenger details cannot be found.");
            }
        }
        public static void CostCal(int i)
        {
            Console.WriteLine("Enter weight of luggage carried by passenger:");
            Double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > i)
            {
                Double diff = weight - i;
                Double amt = diff * 2;
                Console.WriteLine("You need to pay additional amount of {0}$", amt);

            }
            else
            {
                Console.WriteLine("Your baggage checkin is completed.");
            }
        }
    }
}

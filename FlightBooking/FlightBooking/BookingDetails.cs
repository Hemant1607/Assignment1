using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FlightBooking
{
    class BookingDetails
    {
        public static void ShowDetails()
        {
        FileStream fr = new FileStream(@"C:\Users\Hemanth Kumar\source\repos\FlightBooking\FlightBooking\bookingDeatils.txt", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fr);
            sr.ReadLine();
            Console.WriteLine("Name\t\tAge\t\tGender\t\tSource\t\tDestination\tClass");
            while (sr.Peek() > 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    string line = sr.ReadLine();
                    string[] details = line.Split(':');
                    Console.Write(details[1] + "\t\t");
                }
                sr.ReadLine();
                Console.WriteLine();
                /*string name = sr.ReadLine();
                string age = sr.ReadLine();
                string gender = sr.ReadLine();
                string source = sr.ReadLine();
                string destination = sr.ReadLine(); 
                string classtravel = sr.ReadLine();
                sr.ReadLine();
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}",name,age,gender,source,destination,classtravel);*/
            }
            sr.Close();
            fr.Close();
    }
}
}

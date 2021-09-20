using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FlightBooking
{
    class Maintainance
    {
        public static void MainCheck()
        {
            Console.WriteLine("Enter flight number you want to check maintainance details:");
            string check = Console.ReadLine();
            ArrayList MainDone = new ArrayList()
            {
                "FH101", "FH102", "FH103", "FH104"
            };
            ArrayList ToDone = new ArrayList()
            {
                "FH201", "FH202", "FH203", "FH204"
            };
            ArrayList MainGoing = new ArrayList()
            {
                "FH301", "FH302", "FH303", "FH304"
            };
            if (MainDone.Contains(check))
                Console.WriteLine("Maintainance of flight {0} is done.", check);
            else if (ToDone.Contains(check))
                Console.WriteLine("Maintainance of flight {0} is not done yet.", check);
            else if (MainGoing.Contains(check))
                Console.WriteLine("Flight {0} is under maintainance.", check);
            else
                Console.WriteLine("Flight details not available or Enter valid flight number");
        }
    }
}

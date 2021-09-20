using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FlyHigh Airlines");
            Console.WriteLine("Choose one of these options:");
            Console.WriteLine("1.Book Ticket\n2.Check booking details\n3.Check Maintainance Details\n4.Baggage Checkin");
            var num = Console.ReadLine();
            int n;
            if(!int.TryParse(num,out n))
            {
                Console.WriteLine("This is not a number!");
            }
            else if (Convert.ToInt32(num) > 4|| Convert.ToInt32(num)==0)
            {
                Console.WriteLine("Enter valid option from the list");
            }
            else
            {
                if (Convert.ToInt32(num) == 1)
                    bookTickets.TicketBooking();
                else if (Convert.ToInt32(num) == 2)
                    BookingDetails.ShowDetails();
                else if (Convert.ToInt32(num) == 3)
                    Maintainance.MainCheck();
                else if (Convert.ToInt32(num) == 4)
                    Baggage.BaggageDetails();
            }
            Console.Read();
        }
    }
}

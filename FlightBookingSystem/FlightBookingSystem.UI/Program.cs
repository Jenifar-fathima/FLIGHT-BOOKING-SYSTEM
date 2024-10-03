namespace FlightBookingSystem
{
    public class FlightBooking
    {
        public static void Main()
        {
            DataContext.InitializeSeats();
            SeatBooking seatBooking = new SeatBooking();
            Console.WriteLine("Welcome to Flight Booking App");
            while (true)
            {
                Console.WriteLine("List of options:\n1. Book Seat\n2. View Seats\n3. Exit");
                Console.Write("Enter your choice: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            seatBooking.BookSeat();
                            break;
                        case 2:
                            seatBooking.SeatList();
                            break;
                        case 3:
                            return;
                        default:
                            Console.WriteLine("Invalid choice, please select from 1-3.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                }
            }
        }
    }
}
namespace FlightBookingSystem
{
    public class FlightBooking
    {
        public static void Main()
        {
            SeatBooking seatBooking = new SeatBooking();
            Console.WriteLine("Welcome to Flight Booking App");
            Console.WriteLine("List of options:\n1. Book Seat\n2. View Seat\n3. Exit");
            Console.WriteLine("Enter the choice");
            _ = int.TryParse(Console.ReadLine(), out int nChoice);
            switch (nChoice)
            {
                case 1:
                    Console.Write("Enter the seat Type:");
                    string strSeatType = Console.ReadLine();
                    Console.Write("Enter the seat Number:");
                    string strSeatNumber = Console.ReadLine();
                    bool IsSeatAvail = SeatListAvail(strSeatNumber);
                    if(IsSeatAvail)
                    {
                        Console.WriteLine("Seat Booked Successfully");
                    }
                    break;

                case 2:
                    seatBooking.SeatList();
                    break;

                case 3:
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Enter choice from 1-3");
                    break;
            }
        }
        public static bool SeatListAvail(string seatNumber)
        {
            int[] lstSeatRow = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] lstSeatColumn = { "A", "B", "C", "D", "E" };
            string[,] lstSeatName = new string[lstSeatRow.Length, lstSeatColumn.Length];
            for (int i = 0; i < lstSeatRow.Length; i++)
            {
                for (int j = 0; j < lstSeatColumn.Length; j++)
                {
                    lstSeatName[i, j] = lstSeatRow[i] + lstSeatColumn[j] + "-A";
                    Console.Write($"| {lstSeatName[i, j]} |");
                    Console.Write(" ");
                }
                Console.WriteLine("\n--------------------------------------------");
            }

            if( seatNumber == "X")
            {
                return false;
            }
            return true;
        }
    }
}
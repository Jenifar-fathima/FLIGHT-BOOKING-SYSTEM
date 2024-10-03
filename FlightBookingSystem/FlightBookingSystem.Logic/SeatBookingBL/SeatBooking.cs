namespace FlightBookingSystem
{
    public class SeatBooking
    {
        public void BookSeat()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose seat type (Window, Middle, Aisle): ");
            SeatType seatType = (SeatType)Enum.Parse(typeof(SeatType), Console.ReadLine(), true);
            Console.Write("Enter seat number (e.g., 1A): ");
            string inputSeatNumber = Console.ReadLine();
            string seatNumber = inputSeatNumber + "-A";
            var passengerDTO = new PassengerDTO { PassengerName = name, Gender = gender, Age = age };
            var seatDTO = new SeatDTO { SeatType = seatType, SeatNumber = seatNumber };

            if (DataContext.IsSeatAvailable(seatNumber))
            {
                int fare = CalculateFare(age);
                var passenger = new Passenger(passengerDTO);
                var seat = new Seat(seatDTO)
                {
                    Fare = fare,
                    SeatAvailability = SeatAvailability.No
                };
                var updateSeatValue = DataContext.Seats.FirstOrDefault(seat => seat.SeatNumber == seatNumber);
                updateSeatValue.SeatNumber = " X  ";
                DataContext.Passengers.Add(passenger);
                Console.WriteLine("Seat booked successfully!");
                Console.WriteLine("=================================================================");
                Console.WriteLine($"| Name: {name} | Gender: {gender} | SeatNumber: {seatNumber} | Total Fare: {fare} |");
                Console.WriteLine("=================================================================");
            }
            else
            {
                Console.WriteLine("Seat is already booked. Please choose another seat.");
            }
        }
        private int CalculateFare(int age)
        {
            if (age < 2) return 0;
            if (age < 12) return 50;
            return 100;
        }
        public void SeatList()
        {
            Console.WriteLine("Current seat availability:");
            Console.WriteLine("========================  ================");
            Console.WriteLine("|   W  ||   M  ||   A  |  |   A  ||   W  |");
            Console.WriteLine("========================  ================");
            int count = 0;
            foreach (var seat in DataContext.Seats)
            {
                Console.Write($"| {seat.SeatNumber} |");
                if (count < 4)
                {
                    count++;
                    if(count == 3)
                    {
                        Console.Write("  ");
                    }
                }
                else
                {
                    Console.WriteLine("\n----------------------------------------");
                    count = 0;
                }
            }
        }
    }
}
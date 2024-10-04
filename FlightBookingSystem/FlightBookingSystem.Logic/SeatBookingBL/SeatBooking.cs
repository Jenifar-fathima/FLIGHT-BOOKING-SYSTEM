namespace FlightBookingSystem
{
    public class SeatBooking
    {
        public void BookSeat()
        {
            Console.WriteLine(Messages.SeatBookingTitle);
            SeatList();
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter seat number (e.g., 1A): ");
            string inputSeatNumber = Console.ReadLine();
            string seatNumber = inputSeatNumber + "-A";
            var passengerDTO = new PassengerDTO { PassengerName = name, Gender = gender, Age = age };
            var seatDTO = new SeatDTO { SeatNumber = seatNumber };

            if (DataContext.IsSeatAvailable(seatNumber) && age > 2)
            {
                int fare = CalculateFare(age);
                var seat = new Seat(seatDTO)
                {
                    Fare = fare,
                    SeatAvailability = SeatAvailability.No
                };
                var updateSeatValue = DataContext.Seats.FirstOrDefault(seat => seat.SeatNumber == seatNumber);
                updateSeatValue.SeatNumber = " X  ";
                Console.WriteLine(Messages.SeatBookSuccessful);
                Console.WriteLine($"\n| Name: {name} | Gender: {gender} | SeatNumber: {seatNumber} |  SeatType:{updateSeatValue.SeatType}  | Total Fare: {fare} |\n");
            }
            else if(age <= 2)
            {
                Console.WriteLine(Messages.AgeBelowTwo);
            }
            else
            {
                Console.WriteLine(Messages.SeatBookUnsuccessful);
            }
        }
        private int CalculateFare(int age)
        {
            if (age < 12)
            {
                return 50;
            }
            return 100;
        }
        public void SeatList()
        {
            Console.WriteLine(Messages.SeatListTitleMessage);
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
                    Console.WriteLine(Messages.TableLine);
                    count = 0;
                }
            }
        }
    }
}
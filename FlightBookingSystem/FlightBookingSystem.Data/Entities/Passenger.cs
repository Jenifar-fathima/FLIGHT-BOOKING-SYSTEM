using System.Numerics;

namespace FlightBookingSystem
{
    public class Passenger
    {
        public string PassengerName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Passenger(PassengerDTO passengerDTO)
        {
            PassengerName = passengerDTO.PassengerName;
            Gender = passengerDTO.Gender;
            Age = passengerDTO.Age;
        }
    }
}
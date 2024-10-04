namespace FlightBookingSystem
{
    public class SeatDTO
    {
        public SeatType SeatType { get; set; }
        public string SeatNumber { get; set; }
        public SeatAvailability SeatAvailability { get; set; }
        public int Fare { get; set; }
    }
}
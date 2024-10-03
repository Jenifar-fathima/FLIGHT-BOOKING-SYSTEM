namespace FlightBookingSystem
{
    public class SeatDTO
    {
        public string SeatType { get; set; }
        public string SeatNumber { get; set; }
        public bool IsAvailable { get; set; }
        public int Fare { get; set; }
    }
}

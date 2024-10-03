namespace FlightBookingSystem
{
    public class Seat
    {
        public SeatType SeatType {  get; set; }
        public string SeatNumber {  get; set; }
        public SeatAvailability SeatAvailability {  get; set; }
        public int Fare {  get; set; }
        public Seat(SeatDTO seatDTO)
        {
            SeatType = seatDTO.SeatType;
            SeatNumber = seatDTO.SeatNumber;
            SeatAvailability = seatDTO.SeatAvailability;
            Fare = seatDTO.Fare;
        }
    }
}
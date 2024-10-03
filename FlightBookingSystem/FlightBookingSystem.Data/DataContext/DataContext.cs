namespace FlightBookingSystem
{
    public static class DataContext
    {
        public static  List<Passenger> Passengers { get; set; } = new List<Passenger>();
        public static List<Seat> Seats { get; set; } = new List<Seat>();

    }
}

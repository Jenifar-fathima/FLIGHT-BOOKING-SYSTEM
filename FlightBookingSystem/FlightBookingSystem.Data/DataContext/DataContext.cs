namespace FlightBookingSystem
{
    public static class DataContext
    {
        public static List<Seat> Seats { get; set; } = new List<Seat>();

        public static void InitializeSeats()
        {
            int[] lstSeatRow = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] lstSeatColumn = { "A", "B", "C", "D", "E" };
            string[,] lstSeatName = new string[lstSeatRow.Length, lstSeatColumn.Length];
            for (int i = 0; i < lstSeatRow.Length; i++)
            {
                for (int j = 0; j < lstSeatColumn.Length; j++)
                {
                    lstSeatName[i, j] = lstSeatRow[i] + lstSeatColumn[j] + "-A";
                    SeatDTO seatDTO = new SeatDTO
                    {
                        SeatType = (SeatType)(lstSeatColumn[j] == "A" || lstSeatColumn[j] == "E" ? 0 :
                                                lstSeatColumn[j] == "C" || lstSeatColumn[j] == "D" ? 2 :1),
                        SeatNumber = lstSeatName[i, j],
                        SeatAvailability = SeatAvailability.Yes,
                        Fare = 100
                    };
                    Seat seat = new Seat(seatDTO);
                    DataContext.Seats.Add(seat);
                }
            }
        }
        public static bool IsSeatAvailable(string seatNumber)
        {
            var seatAvail = DataContext.Seats.FirstOrDefault(seat => seat.SeatNumber == seatNumber);
            if (seatAvail == null)
            {
                return false;
            }
            return true;
        }
    }
}
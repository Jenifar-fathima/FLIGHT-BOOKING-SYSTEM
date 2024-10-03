namespace FlightBookingSystem
{
    public class SeatBooking
    {
        ApiResponse<bool> api = new ApiResponse<bool>();
        public ApiResponse<bool> CheckSeatAvailability(string strSeatNumber)
        {
            return api; 
        }
        public void SeatList()
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
        }
    }
}

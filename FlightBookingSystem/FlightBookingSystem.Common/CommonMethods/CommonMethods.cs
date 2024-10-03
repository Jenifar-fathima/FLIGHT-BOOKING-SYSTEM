namespace FlightBookingSystem
{
    public static class CommonMethods
    {
        public static void SeatList()
        {
            int[] lstSeatRow = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] lstSeatColumn = { "A", "B", "C", "D", "E" };
            string[,] lstSeats = new string[lstSeatRow.Length, lstSeatColumn.Length];
            string[,] lstSeatName = new string[lstSeatRow.Length, lstSeatColumn.Length];
            for (int i = 0; i < lstSeatRow.Length; i++)
            {
                for (int j = 0; j < lstSeatColumn.Length; j++)
                {
                    lstSeats[i, j] = "A";
                    lstSeatName[i, j] = lstSeatRow[i] + lstSeatColumn[j];
                    Console.Write($"| {lstSeatName[i, j]}-{lstSeats[i, j]} |");
                    Console.Write(" ");
                }
                Console.WriteLine("\n--------------------------------------------");
            }
        }
    }
}

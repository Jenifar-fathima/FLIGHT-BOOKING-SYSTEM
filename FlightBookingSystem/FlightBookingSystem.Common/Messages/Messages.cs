namespace FlightBookingSystem
{
    public class Messages
    {
        public const string WelcomeMessage = "Welcome to Flight Booking App";
        public const string ChoiceListMessage = "List of options:\n1. Book Seat\n2. View Seats\n3. Exit\n";
        public const string SeatListTitleMessage = "      Current seat availability      \n" +
                                                "| W - Window |  M - Middle |  A - Aisle  |\n\n"+
                                                " =======================  =============== \n" +
                                                "|   W  ||   M  ||   A  |  |   A  ||   W  |\n" +
                                                " =======================  =============== ";
        public const string InvalidChoiceMessage = "Invalid choice, please select from 1-3.";
        public const string InvalidChoiceUnputMessage = "Invalid input, please enter a number.";
        public const string SeatBookSuccessful = " ===============================================================\n" +
                                                 "||                   Seat booked successfully!                 ||\n" +
                                                 " ===============================================================";

        public const string SeatBookUnsuccessful = "Seat is already booked. Please choose another seat.";

        public const string TableLine = "\n------------------------------------------";
        public const string SeatBookingTitle = " ============================================================= \n" +
                                               "||                     Seat Booking Portal                   ||\n" +
                                               " ============================================================= \n";
        public const string AgeBelowTwo = " ============================================================= \n" +
                                          "||Seats cannot be reserved for children under the age of two.||\n" +
                                          " ============================================================= ";
        }
}
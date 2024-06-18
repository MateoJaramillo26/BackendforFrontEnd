namespace BackendforFrontEnd.Models
{
    public class Flight
    {
        public required String FlightID { get; set; }
        public required String Airline { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public decimal Price { get; set; }
    }
}

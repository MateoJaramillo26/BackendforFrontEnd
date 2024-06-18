using BackendforFrontEnd.Models;
using Refit;

namespace BackendforFrontEnd.Services
{
    public interface IBffService
    {

        [Get("/flights")]
        Task<List<Flight>> GetFlightsAsync();
    }
}

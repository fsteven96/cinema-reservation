using CinemaReservation.Application.Interfaces;
using CinemaReservation.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace CinemaReservation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : ControllerBase
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        [HttpGet("by-genre")]
        public async Task<IActionResult> GetBookingsByGenreAndDateRange(
            [FromQuery] MovieGenreEnum genre,
            [FromQuery] DateTime startDate,
            [FromQuery] DateTime endDate)
        {
            var result = await _bookingRepository.GetBookingsByGenreAndDateRangeAsync(genre, startDate, endDate);
            return Ok(result);
        }

        [HttpGet("available-seats")]
        public async Task<IActionResult> GetAvailableSeats(
            [FromQuery] int roomId,
            [FromQuery] DateTime date)
        {
            var available = await _bookingRepository.GetAvailableSeatsCountAsync(roomId, date);
            return Ok(new { available });
        }

        [HttpGet("occupied-seats")]
        public async Task<IActionResult> GetOccupiedSeats(
            [FromQuery] int roomId,
            [FromQuery] DateTime date)
        {
            var occupied = await _bookingRepository.GetOccupiedSeatsCountAsync(roomId, date);
            return Ok(new { occupied });
        }
    }
}

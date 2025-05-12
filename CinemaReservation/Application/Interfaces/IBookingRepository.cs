using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CinemaReservation.Domain.Enums;
using CinemaReservation.Domain.Entities;

namespace CinemaReservation.Application.Interfaces
{
    public interface IBookingRepository
    {
        Task<IEnumerable<BookingEntity>> GetBookingsByGenreAndDateRangeAsync(MovieGenreEnum genre, DateTime startDate, DateTime endDate);
        Task<int> GetAvailableSeatsCountAsync(int roomId, DateTime date);
        Task<int> GetOccupiedSeatsCountAsync(int roomId, DateTime date);
    }
}

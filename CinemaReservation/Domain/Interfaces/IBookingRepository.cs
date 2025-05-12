using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CinemaReservation.Domain.Entities;

namespace CinemaReservation.Domain.Interfaces
{
    public interface IBookingRepository : IRepository<BookingEntity>
    {
        Task<IEnumerable<BookingEntity>> GetBookingsByGenreAndDateRangeAsync(string genre, DateTime startDate, DateTime endDate);
        Task<int> GetAvailableSeatsCountAsync(int roomId, DateTime date);
        Task<int> GetOccupiedSeatsCountAsync(int roomId, DateTime date);
    }
}


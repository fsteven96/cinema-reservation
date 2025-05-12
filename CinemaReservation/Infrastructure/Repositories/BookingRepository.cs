using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CinemaReservation.Application.Interfaces;
using CinemaReservation.Domain.Entities;
using CinemaReservation.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace CinemaReservation.Infrastructure.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly CinemaDbContext _context;

        public BookingRepository(CinemaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BookingEntity>> GetBookingsByGenreAndDateRangeAsync(MovieGenreEnum genre, DateTime startDate, DateTime endDate)
        {
            return await _context.Bookings
                .Include(b => b.Billboard)
                    .ThenInclude(bb => bb.Movie)
                .Where(b => b.Billboard.Movie.Genre == genre &&
                            b.Billboard.Date.Date >= startDate.Date &&
                            b.Billboard.Date.Date <= endDate.Date)
                .ToListAsync();
        }

        public async Task<int> GetAvailableSeatsCountAsync(int roomId, DateTime date)
        {
            var totalSeats = await _context.Seats.CountAsync(s => s.RoomId == roomId);

            var occupied = await _context.Bookings
                .Include(b => b.Billboard)
                .Where(b => b.Billboard.RoomId == roomId &&
                            b.Billboard.Date.Date == date.Date)
                .CountAsync();

            return totalSeats - occupied;
        }

        public async Task<int> GetOccupiedSeatsCountAsync(int roomId, DateTime date)
        {
            return await _context.Bookings
                .Include(b => b.Billboard)
                .Where(b => b.Billboard.RoomId == roomId &&
                            b.Billboard.Date.Date == date.Date)
                .CountAsync();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using CinemaReservation.Domain.Entities;

namespace CinemaReservation.Infrastructure
{
    public class CinemaDbContext : DbContext
    {
        public DbSet<MovieEntity> Movies { get; set; }
        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<SeatEntity> Seats { get; set; }
        public DbSet<BookingEntity> Bookings { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<BillboardEntity> Billboards { get; set; }

        public CinemaDbContext(DbContextOptions<CinemaDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<BookingEntity>()
        .HasOne(b => b.Seat)
        .WithMany() // si no tienes propiedad inversa
        .HasForeignKey(b => b.SeatId)
        .OnDelete(DeleteBehavior.Restrict);
         
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaReservation.Domain.Entities
{
    public class BookingEntity : BaseEntity
    {
        [Required]
        public DateTime Date { get; set; }

    
        public int CustomerId { get; set; }
        public CustomerEntity Customer { get; set; }

   
        public int SeatId { get; set; }
        public SeatEntity Seat { get; set; }

        public int BillboardId { get; set; }
        public BillboardEntity Billboard { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using CinemaReservation.Domain.Enums;

namespace CinemaReservation.Domain.Entities
{
    public class MovieEntity : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public MovieGenreEnum Genre { get; set; }

        [Required]
        public short AllowedAge { get; set; }

        [Required]
        public short LengthMinutes { get; set; }
    }
}

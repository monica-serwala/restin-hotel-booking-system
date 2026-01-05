using System.ComponentModel.DataAnnotations;
namespace HotelBookingManagementSystem.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        [Required]
        public string BedroomId { get; set; }
        [Required]
        public string GuestName { get; set; }
        [Required]
        public DateTime CheckInDate { get; set; }
        [Required]
        public DateTime CheckOutDate { get; set; }
        public BookingStatus Status { get; set; } = BookingStatus.Draft;
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

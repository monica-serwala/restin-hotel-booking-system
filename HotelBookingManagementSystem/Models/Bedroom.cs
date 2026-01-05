using System.ComponentModel.DataAnnotations;

namespace HotelBookingManagementSystem.Models

{
    public class Bedroom
    {
        public int BedroomId {  get; set; }
        [Required]
        public string RoomNumber { get; set; }
        [Required]
        public RoomType RoomType { get; set; }
        [Range(1, 10)]
        public string Capacity { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;

    }
}

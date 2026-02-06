using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class Course
    {
        // Primary key
        public int Id { get; set; }

        // Course code (e.g.,"PROG3176")
        [Required(ErrorMessage = "Course code is required")]
        [RegularExpression(@"^[A-Z]{3,4}\d{4}$", 
            ErrorMessage = "Course code must be 3-4 uppercase letters followed by 4 digits (e.g., PROG3176)")]
        public string CourseCode { get; set; }

        // Course name (e.g., "Distributed Applications Development")
        [Required(ErrorMessage = "Course name is required")]
        [StringLength(100, ErrorMessage = "Course name cannot exceed 100 characters")]
        public string CourseName { get; set; }

        // Credits (1 to 6 range)
        [Required]
        [Range(1, 6, ErrorMessage = "Credits must be between 1 and 6")]
        public int Credits { get; set; }

        // Delivery mode (Online, InPerson, Hybrid)
        [Required(ErrorMessage = "Delivery mode is required")]
        public DeliveryMode DeliveryMode { get; set; }

        // Course description (optional)
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string? Description { get; set; }
    }

    // Enum for course delivery modes
    public enum DeliveryMode
    {
        Online,
        InPerson,
        Hybrid
    }
}
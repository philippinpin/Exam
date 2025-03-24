using System.ComponentModel.DataAnnotations;

namespace FeedbackManagementSystem.Models
{
    public class FeedbackModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Feedback message is required")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Feedback must be between 10 and 200 characters")]
        [Display(Name = "Feedback Message")]
        public string FeedbackMessage { get; set; }
    }
}
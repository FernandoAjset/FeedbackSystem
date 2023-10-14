using Domain.Enums;

namespace Application.DTOs
{
    public class FeedbackDto
    {
        public string Description { get; set; }
        public FeedbackType Type { get; set; }
    }
}
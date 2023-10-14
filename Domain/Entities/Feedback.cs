using Domain.Enums;

namespace Domain.Entities
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public FeedbackType Type { get; set; }
    }

}
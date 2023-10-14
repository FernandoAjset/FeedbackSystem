using Application.DTOs;

namespace Application.Services.Interfaces
{
    public interface IFeedbackService
    {
        Task AddFeedbackAsync(FeedbackDto feedbackDto);
        Task<IEnumerable<FeedbackDto>> GetAllFeedbackAsync();
    }
}

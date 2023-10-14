using Domain.Entities;

namespace Domain.Repositories
{
    public interface IFeedbackRepository
    {
        Task AddAsync(Feedback feedback);
        Task<IEnumerable<Feedback>> GetAllAsync();
    }
}

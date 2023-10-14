using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class FeedbackRepository : IFeedbackRepository
    {
        private readonly AppDbContext appDbContext;

        public FeedbackRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task AddAsync(Feedback feedback)
        {
            appDbContext.Feedbacks.Add(feedback);
            await appDbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Feedback>> GetAllAsync()
        {
            return await appDbContext.Feedbacks.ToListAsync();
        }
    }

}

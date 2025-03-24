using FeedbackManagementSystem.Models;

namespace FeedbackManagementSystem.Services
{
    public interface IFeedbackRepository
    {
        void AddFeedback(FeedbackModel feedback);
        List<FeedbackModel> GetAllFeedback();
    }

    public class FeedbackRepository : IFeedbackRepository
    {
        private static List<FeedbackModel> _feedbacks = new List<FeedbackModel>();

        public void AddFeedback(FeedbackModel feedback)
        {
            _feedbacks.Add(feedback);
        }

        public List<FeedbackModel> GetAllFeedback()
        {
            return _feedbacks;
        }
    }
}
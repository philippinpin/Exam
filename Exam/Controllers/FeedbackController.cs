using FeedbackManagementSystem.Models;
using FeedbackManagementSystem.Services;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackManagementSystem.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepository _feedbackRepository;

        public FeedbackController(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }

        // GET: Feedback/FeedbackForm
        public IActionResult FeedbackForm()
        {
            return View();
        }

        // POST: Feedback/SubmitFeedback
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitFeedback(FeedbackModel feedback)
        {
            if (ModelState.IsValid)
            {
                _feedbackRepository.AddFeedback(feedback);
                return RedirectToAction(nameof(ThankYou), feedback);
            }
            return View("FeedbackForm", feedback);
        }

        // GET: Feedback/FeedbackList
        public IActionResult FeedbackList()
        {
            var feedbacks = _feedbackRepository.GetAllFeedback();
            return View(feedbacks);
        }

        // GET: Feedback/ThankYou
        public IActionResult ThankYou(FeedbackModel feedback)
        {
            return View(feedback);
        }
    }
}
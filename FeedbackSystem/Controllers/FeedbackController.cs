using Application.DTOs;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackSystem.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var feedbacks = await _feedbackService.GetAllFeedbackAsync();
            return View(feedbacks);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(FeedbackDto feedbackDto)
        {
            if (!ModelState.IsValid) return View(feedbackDto);
            await _feedbackService.AddFeedbackAsync(feedbackDto);
            return RedirectToAction("Index");
        }
    }

}

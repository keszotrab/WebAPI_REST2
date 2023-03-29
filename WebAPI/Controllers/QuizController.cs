using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("/api/v1/quizzes")]
    public class QuizController : Controller
    {
        private readonly IQuizUserService _service;
        public QuizController(IQuizUserService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
//IQuizUserService po nazwą _service
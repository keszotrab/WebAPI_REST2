using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WebAPI.Dto;

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

        [HttpGet]
        [Route("{id}")]
        public ActionResult<QuizDto> FindById(int id)
        {
            var item = QuizDto.of(_service.FindQuizById(id));

            return item == null ? NotFound() : Ok(item);
        }

        [HttpGet]
        public IEnumerable<QuizDto> FindAll()
        {
            List<QuizDto> AllQuizzesDto= new List<QuizDto>();
            IEnumerable<Quiz> allQuizes = _service.FindAllQuizzes();
            foreach (var item in allQuizes)
            {
                AllQuizzesDto.Add(QuizDto.of(item));
            }

            return AllQuizzesDto;
        }

        [HttpPost]
        [Route("{quizId}/items/{itemId}")]
        public void SaveAnswer([FromBody] QuizItemAnswerDto dto, int quizId, int itemId )
        {
            _service.SaveUserAnswerForQuiz(quizId, dto.UserId, itemId, dto.Answer);
            
        }
    }
}
//IQuizUserService po nazwą _service
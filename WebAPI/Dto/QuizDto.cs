using ApplicationCore.Models;

namespace WebAPI.Dto
{
    public class QuizDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<QuizItemDto> Items { get; set; }

        public static QuizDto? of(Quiz quiz)
        {
            QuizDto quizDto = new QuizDto();
            quizDto.Id = quiz.Id;
            quizDto.Title = quiz.Title;
            foreach (var item in quiz.Items)
            {
                quizDto.Items.Add(QuizItemDto.of(item));

            }
            return quizDto;
        }
    }
}

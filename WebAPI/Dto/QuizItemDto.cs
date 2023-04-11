using ApplicationCore.Models;
using System.Collections.Generic;

namespace WebAPI.Dto
{
    public class QuizItemDto
    {
        public int Id;
        public string Question;
        public List<string> Options;
        //TODO
        //Lista popra wnych i niepoprawnych 

        public static QuizItemDto? of(QuizItem quiz)
        {
            QuizItemDto quizItemDto= new QuizItemDto();
            quizItemDto.Id = quiz.Id;
            quizItemDto.Question = quiz.Question;
            foreach (var item in quiz.IncorrectAnswers)
            {
                quizItemDto.Options.Add(item);
            }
            quizItemDto.Options.Add(quiz.CorrectAnswer);


            Random rng = new Random();
            int n = quizItemDto.Options.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = quizItemDto.Options[k];
                quizItemDto.Options[k] = quizItemDto.Options[n];
                quizItemDto.Options[n] = value;
            }
            return quizItemDto;
        }
    }
}

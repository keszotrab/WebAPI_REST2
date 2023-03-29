using ApplicationCore.Models;

namespace WebAPI.Dto
{
    public class QuizItemDto
    {
        public int Id;
        public string Question;
        public List<string> Options;
        //TODO
        //Lista popra wnych i niepoprawnych 

        public static QuizItemDto of(QuizItem quiz)
        {
            return null;  ///////// asdjphasdgashlfgafklsl
        }
    }
}

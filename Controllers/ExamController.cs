using IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Hernandez_Adrien.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Hernandez_Adrien.Controllers
{
    public class ExamController : Controller
    {
        private static readonly List<Question> Questions = new()
        {
            new Question
            {
                Number = 1,
                QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
                Answer = "C. It allows data to persist after the application stops."
            }
        };

        public IActionResult Index()
        {
            return View(Questions);
        }
    }
}
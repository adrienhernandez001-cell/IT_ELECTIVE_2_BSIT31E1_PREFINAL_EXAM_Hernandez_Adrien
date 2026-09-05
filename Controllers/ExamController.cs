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
            },
            new Question
            {
                Number = 2,
                QuestionText = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                Answer = "B. Database-First"
            },
            new Question
            {
                Number = 3,
                QuestionText = "What is the primary purpose of Entity Framework Core?",
                Answer = "C. To map objects in code to relational database data"
            },
            new Question
            {
                Number = 4,
                QuestionText = "Which EF Core component is primarily responsible for communicating with the database?",
                Answer = "A. DbContext"
            },
            new Question
            {
                Number = 5,
                QuestionText = "What does the following command primarily do? dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                Answer = "C. Generates EF Core models and a DbContext from an existing database"
            },
            new Question
            {
                Number = 6,
                QuestionText = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                Answer = "B. appsettings.json"
            },
            new Question
            {
                Number = 7,
                QuestionText = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                Answer = "B. One-to-Many"
            },
            new Question
            {
                Number = 8,
                QuestionText = "In the following example, what is SectionId? public int SectionId { get; set; } public Section Section { get; set; }",
                Answer = "B. Foreign key referencing Section"
            },
            new Question
            {
                Number = 9,
                QuestionText = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                Answer = "B. It represents a relationship to another entity"
            },
            new Question
            {
                Number = 10,
                QuestionText = "What does .Include() generally allow EF Core to do?",
                Answer = "B. Load related Section data together with Students"
            },
            new Question
            {
                Number = 11,
                QuestionText = "Why might a ViewModel be used when displaying Student and Section information?",
                Answer = "B. To combine or shape the data specifically needed by the view"
            },
            new Question
            {
                Number = 12,
                QuestionText = "Consider this query: var students = _context.Students.Include(s => s.Section).ToList(); What is the main benefit of Include(s => s.Section)?",
                Answer = "A. It loads the related Section navigation property"
            },
            new Question
            {
                Number = 13,
                QuestionText = "Which type of validation occurs in the browser before a request is sent to the server?",
                Answer = "B. Client-side validation"
            },
            new Question
            {
                Number = 14,
                QuestionText = "Why is server-side validation still necessary if client-side validation exists?",
                Answer = "A. Client-side validation can be bypassed"
            },
            new Question
            {
                Number = 15,
                QuestionText = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                Answer = "B. Student Number should be unique"
            },
            new Question
            {
                Number = 16,
                QuestionText = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
                Answer = "A. It protects data integrity even if application-level validation is bypassed"
            },
            new Question
            {
                Number = 17,
                QuestionText = "What is the purpose of a try...catch block in a controller?",
                Answer = "B. To catch and handle exceptions that may occur during execution"
            },
            new Question
            {
                Number = 18,
                QuestionText = "Which middleware is commonly used in ASP.NET Core for centralized exception handling?",
                Answer = "B. UseExceptionHandler()"
            },
            new Question
            {
                Number = 19,
                QuestionText = "A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?",
                Answer = "B. Display a Not Found (404) response/page"
            },
            new Question
            {
                Number = 20,
                QuestionText = "A student already belongs to Section A for a particular subject. The application attempts to assign the same student to Section A again. What is the primary concern?",
                Answer = "A. Data integrity"
            }
        };

        public IActionResult Index()
        {
            return View(Questions);
        }
    }
}
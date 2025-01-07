using Microsoft.AspNetCore.Mvc;
using studentList.Services; // This allows us to add our apiContoller

namespace studentList.Controllers
{
    [ApiController] // This tells the file to read this as an API Controller
    [Route("[controller]")] // removing the api/ we no longer need to type it in our url.
    public class StudentListController : ControllerBase
    {
        // we are creating an empty reference to our services
        private readonly StudentListServices _studentListServices;

        //The Constructer runs first when the api is called
        // Web API version of void start from unity
        public StudentListController(StudentListServices studentListServices)
        {
            _studentListServices = studentListServices;
        }


        [HttpGet] //Use HttpGet to request Information or "Get info"
        [Route("FetchStudentList")]
        public List<string> GetStudents()
        {
            return _studentListServices.GetStudents();
        }


        [HttpPost] //Use HttpPost for Adding Informantion to the backend 
        [Route("AddStudent/{studentTooAdd}")] //To pass data though our routes we add /{parameter}
        public List<string> AddToStudentList(string studentTooAdd)
        {
            return _studentListServices.AddStudentList(studentTooAdd);
        }


        [HttpDelete] //HttpDelete when removing information for our data
        [Route("RemoveStudent/{studentToRemove}")]
        public List<string> RemoveStudentFromList(string studentToRemove)
        {
            return _studentListServices.RemoveFromStudentList(studentToRemove);
        }
        

        [HttpPut] //use HttpPut for editing information in the database
        [Route("EditStudent/{studentToEdit}/{newStudentName}")]
        public List<string> EditStudentFromList(string studentToEdit, string newStudentName)
        {
            // We are going to find the Index at which studentToEdit exists and then change the value of that index
            return _studentListServices.EditStudentFromList(studentToEdit, newStudentName);
        }
    }
}
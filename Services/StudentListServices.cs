using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace studentList.Services
{
    public class StudentListServices
    {
        public List<string> studentList = new();

        public StudentListServices()
        {
            studentList.Add("Jacob");
            studentList.Add("Mr. Hackerman");
        }

        public List<string> GetStudents()
        {
            return studentList;
        }

        public List<string> AddStudentList(string studentTooAdd)
        {
            studentList.Add(studentTooAdd);
            return studentList;
        }

        public List<string> RemoveFromStudentList(string studentToRemove)
        {
            studentList.Remove(studentToRemove);
            return studentList;
        }

        public List<string> EditStudentFromList(string studentToEdit, string newStudentName)
        {
            studentList[studentList.IndexOf(studentToEdit)] = newStudentName;
            return studentList;
        }
    }
}
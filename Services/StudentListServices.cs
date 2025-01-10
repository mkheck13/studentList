using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using studentList.Context;
using studentList.Models;

namespace studentList.Services
{
    public class StudentListServices
    {
        public List<StudentModel> studentList = new();
        private readonly DataContext _dataBase;

        public StudentListServices(DataContext dataContext)
        {
            _dataBase = dataContext;
        }

        public List<StudentModel> GetStudents()
        {
            return _dataBase.Students.ToList();
        }

        public List<StudentModel> AddStudentList(string studentTooAdd)
        {
            StudentModel student = new();
            student.Name = studentTooAdd;

            _dataBase.Students.Add(student);
            _dataBase.SaveChanges();
            return _dataBase.Students.ToList();
        }

        public List<StudentModel> RemoveFromStudentList(string studentToRemove)
        {
            var student = _dataBase.Students.FirstOrDefault(student => student.Name == studentToRemove);
            _dataBase.Students.Remove(student);
            _dataBase.SaveChanges();
            return _dataBase.Students.ToList();
        }

        public List<StudentModel> EditStudentFromList(string studentToEdit, string newStudentName)
        {
            var student = _dataBase.Students.FirstOrDefault(student => student.Name == studentToEdit);

            student.Name = newStudentName;

            _dataBase.Students.Update(student);
            _dataBase.SaveChanges();
            return _dataBase.Students.ToList();
        }
    }
}
using InfoSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace InfoSys
{
    public class StudentRepository
    {
        private readonly List<Student> _students;

        public StudentRepository()
        {
            _students = new List<Student>();
        }

        public async Task<List<Student>> Get()
        {
            return await Task.Run(() => _students);
        }

        public async Task<Student> GetStudent(int Id)
        {
            return await Task.Run(() => _students.FirstOrDefault(f => f.Id == Id));
        }
        public async Task<Student> AddStudent(Student student)
        {
            _students.Add(student);
        }
    }
}
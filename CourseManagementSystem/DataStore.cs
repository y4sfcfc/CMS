using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    internal class DataStore
    {
        public static List<Group> groups { get; set; }
        public static List<Teacher> teachers { get; set; }
        public static List<Mentor> mentors { get; set; }
        public static List<Student> students { get; set; }

        static DataStore()
        {
            groups = new List<Group>();
            teachers = new List<Teacher>();
            mentors = new List<Mentor>();
            students = new List<Student>();
        }

    }
}

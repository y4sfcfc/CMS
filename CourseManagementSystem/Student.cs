using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    internal class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


       

        public void AddStudent()
        {
            Student newStudent = new Student();

            Console.Write("Telebenin ID-i daxil edin (3-300): ");
            newStudent.StudentID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Telebenin adini daxil edin: ");
            newStudent.Name = Console.ReadLine();

            Console.Write("Telebenin soyadini daxil edin: ");
            newStudent.Surname = Console.ReadLine();

            DataStore.students.Add(newStudent);
            Console.WriteLine("Telebe elave edildi!");
        }

        public void ModifyStudent()
        {
            Console.Write("Deyismek istediyiniz telebenin ID-i daxil edin: ");
            int ID = int.Parse(Console.ReadLine());

            Student telebe = DataStore.students.Find(t => t.StudentID == ID);
            if (telebe != null)
            {
                Console.Write("Yeni adi daxil edin: ");
                telebe.Name = Console.ReadLine();

                Console.Write("Yeni tapilmadi daxil edin: ");
                telebe.Surname = Console.ReadLine();

                Console.WriteLine("Telebe melumatlari deyisdirildi!");
            }
            else
            {
                Console.WriteLine("Telebe tapilmadi!");
            }
        }

        public void RemoveStudent()
        {
            Console.Write("Silmek istediyiniz telebenin ID-i daxil edin: ");
            int ID = int.Parse(Console.ReadLine());

            Student telebe = DataStore.students.Find(t => t.StudentID == ID);
            if (telebe != null)
            {
                DataStore.students.Remove(telebe);
                Console.WriteLine("Telebe silindi!");
            }
            else
            {
                Console.WriteLine("Telebe tapilmadi!");
            }
        }

        public void DisplayStudent()
        {
            Console.WriteLine("Telebe məlumatları:");
            foreach (Student telebe in DataStore.students)
            {
                Console.WriteLine($"ID: {telebe.StudentID}, Ad: {telebe.Name}, Soyad: {telebe.Surname}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    internal class Teacher
    { 
    public int TeacherID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }


    

    public void AddTeacher()
    {
        Teacher newTeacher = new Teacher();

        Console.Write("Muellimin ID-i daxil edin (1-100): ");
        newTeacher.TeacherID = int.Parse(Console.ReadLine());

        Console.Write("Muellimin adını daxil edin: ");
        newTeacher.Name = Console.ReadLine();

        Console.Write("Muellimin soyadını daxil edin: ");
        newTeacher.Surname = Console.ReadLine();

        DataStore.teachers.Add(newTeacher);
        Console.WriteLine("Muellim elave edildi!");
    }

    public void ModifyTeacher()
    {
        Console.Write("DEyismek istediyiniz muellimin ID-i daxil edin: ");
        int ID = int.Parse(Console.ReadLine());

        Teacher teacher = DataStore.teachers.Find(m => m.TeacherID == ID);
        if (teacher != null)
        {
            Console.Write("Yeni adı daxil edin: ");
            teacher.Name = Console.ReadLine();

            Console.Write("Yeni soyadı daxil edin: ");
            teacher.Surname = Console.ReadLine();

            Console.WriteLine("Muellim melumatlari deyisdirildi!");
        }
        else
        {
            Console.WriteLine("Muellim tapılmadı!");
        }
    }

    public void RemoveTeacher()
    {
        Console.Write("Silmek istediyiniz muellimin ID-i daxil edin: ");
        int ID = int.Parse(Console.ReadLine());

        Teacher mueellim = DataStore.teachers.Find(m => m.TeacherID == ID);
        if (mueellim != null)
        {
            DataStore.teachers.Remove(mueellim);
            Console.WriteLine("Muellim silindi!");
        }
        else
        {
            Console.WriteLine("Muellim tapilmadi!");
        }
    }

    public void DisplayTeacher()
    {
        Console.WriteLine("Muellim melumatlari:");
        foreach (Teacher teacher in DataStore.teachers)
        {
            Console.WriteLine($"ID: {teacher.TeacherID}, Ad: {teacher.Name}, Soyad: {teacher.Surname}");
        }
    }

}
}

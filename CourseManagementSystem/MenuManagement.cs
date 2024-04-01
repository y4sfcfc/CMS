using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    internal class MenuManagement
    {
        public static void SelectOperation()
        {
            Console.WriteLine("1.Qrup uzre emeliyyatlar");
            Console.WriteLine("2.Muellim uzre emeliyyatlar");
            Console.WriteLine("3.Mentor uzre emeliyyatlar");
            Console.WriteLine("4.Telebe uzre emeliyyatlar");
            Console.WriteLine("5.Exit");
            Console.Write("Zehmet olmasa seciminizi daxil edin:");
            int option = int.Parse(Console.ReadLine());
           
        }
        public static void GroupOperations()
        {
            Group group = new Group();
            while (true)
            {
                Console.WriteLine("1. Qrup elave et");
                Console.WriteLine("2. Qrup meulamatlarini deyis");
                Console.WriteLine("3. Qrup meulamatlarini sil");
                Console.WriteLine("4. Qrup meulamatlarini goster");
                Console.WriteLine("5. Cixis");
                Console.Write("Seciminizi edin: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        group.AddGroup();
                        break;
                    case "2":
                        group.ModifyGroup();
                        break;
                    case "3":
                        group.RemoveGroup();
                        break;
                    case "4":
                        group.DisplayGroup();
                        break;
                    case "5":
                        Console.WriteLine("Proqramdan cixilir...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlıs secim! Zəhmət olmasa dogru secimi edin.");
                        break;
                }
            }
        }
        public static void TeacherOperations()
        {
            Teacher teacher = new Teacher();
            while (true)
            {
                Console.WriteLine("1. Muellim elave et");
                Console.WriteLine("2. Muellim meulamatlarini deyis");
                Console.WriteLine("3. Muellim meulamatlarini sil");
                Console.WriteLine("4. Muellim meulamatlarini goster");
                Console.WriteLine("5. Cixis");
                Console.Write("Seciminizi edin: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        teacher.AddTeacher();
                        break;
                    case "2":
                        teacher.ModifyTeacher();
                        break;
                    case "3":
                        teacher.RemoveTeacher();
                        break;
                    case "4":
                        teacher.DisplayTeacher();
                        break;
                    case "5":
                        Console.WriteLine("Proqramdan cixilir...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlıs secim! Zəhmət olmasa dogru secimi edin.");
                        break;
                }
            }
        }
        public static void MentorOperations()
        {
            Mentor mentor = new Mentor();
            while (true)
            {
                Console.WriteLine("1. Mentor elave et");
                Console.WriteLine("2. Mentor melumatlarini deyis");
                Console.WriteLine("3. Mentor melumatlarini sil");
                Console.WriteLine("4. Mentor melumatlarini goster");
                Console.WriteLine("5. Cixis");
                Console.Write("Seciminizi edin: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        mentor.AddMentor();
                        break;
                    case "2":
                        mentor.ModifyMentor();
                        break;
                    case "3":
                        mentor.RemoveMentor();
                        break;
                    case "4":
                        mentor.DisplayMentor();
                        break;
                    case "5":
                        Console.WriteLine("Proqramdan cixilir");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlıs secim! Zehmet olmasa dogru secimi edin.");
                        break;
                }
            }
        }
        public static void StudentOperations()
        {
           Student student = new Student();
            while (true)
            {
                Console.WriteLine("1. Telebe elave et");
                Console.WriteLine("2. Telebe melumatlarini deyis");
                Console.WriteLine("3. Telebe melumatlarini sil");
                Console.WriteLine("4. Telebe melumatlarini goster");
                Console.WriteLine("5. Cixis");
                Console.Write("Seciminizi edin: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        student.AddStudent();
                        break;
                    case "2":
                        student.ModifyStudent();
                        break;
                    case "3":
                        student.RemoveStudent();
                        break;
                    case "4":
                        student.DisplayStudent();
                        break;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlis secim! Zehmet olmasa dogru sccimi edin.");
                        break;
                }
            }
        }
    }
}


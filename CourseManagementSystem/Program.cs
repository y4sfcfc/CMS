namespace CourseManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuManagement menuManagement = new MenuManagement();
            Group group = new Group();
            Teacher teacher = new Teacher();
            Mentor maestor = new Mentor();
            Student student = new Student();
            SelectOperations();
        }

        static void SelectOperations()
        {
            while (true)
            {
                Console.WriteLine("1.Qrup uzre emeliyyatlar");
                Console.WriteLine("2.Muellim uzre emeliyyatlar");
                Console.WriteLine("3.Mentor uzre emeliyyatlar");
                Console.WriteLine("4.Telebe uzre emeliyyatlar");
                Console.WriteLine("5.Cixis");
                Console.Write("Zehmet olmasa seciminizi daxil edin:");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        MenuManagement.GroupOperations();
                        break;
                    case 2:
                        MenuManagement.TeacherOperations();
                        break;
                    case 3:
                        MenuManagement.MentorOperations();
                        break;
                    case 4:
                        MenuManagement.StudentOperations();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Düzgün seçim edin!");
                        break;
                }
            }
        }
    }
}


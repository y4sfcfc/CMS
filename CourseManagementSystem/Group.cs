using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    internal class Group
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }

        public List<Student> students = new List<Student>();
        public List<Mentor> mentors = new List<Mentor>();
        public List<Teacher> teachers = new List<Teacher>();

        public void AddGroup()
        {
            Group newGroup = new Group();

            Console.Write("Qrupun ID-i daxil edin (1-100): ");
            newGroup.GroupID = int.Parse(Console.ReadLine());

            Console.Write("Qrupun adını daxil edin: ");
            newGroup.GroupName = Console.ReadLine();

            DataStore.groups.Add(newGroup);
            Console.WriteLine("Qrup elave edildi!");
        }
        public void ModifyGroup()
        {
            Console.Write("DEyismek istediyiniz qrupun ID-i daxil edin: ");
            int ID = int.Parse(Console.ReadLine());

            Group group = DataStore.groups.Find(g => g.GroupID == ID);
            if (group != null)
            {
                Console.Write("Yeni adı daxil edin: ");
                group.GroupID = int.Parse(Console.ReadLine());

                Console.Write("Yeni soyadı daxil edin: ");
                group.GroupName = Console.ReadLine();

                Console.WriteLine("Muellim melumatlari deyisdirildi!");
            }
            else
            {
                Console.WriteLine("Qrup tapılmadı!");
            }
        }

        public void RemoveGroup()
        {
            Console.Write("Silmek istediyiniz qrupun ID-i daxil edin: ");
            int ID = int.Parse(Console.ReadLine());

            Group group = DataStore.groups.Find(g => g.GroupID == ID);
            if (group != null)
            {
                DataStore.groups.Remove(group);
                Console.WriteLine("Qrup silindi!");
            }
            else
            {
                Console.WriteLine("Qrup tapilmadi!");
            }
        }

        public void DisplayGroup()
        {
            Console.WriteLine("Telebe məlumatları:");
            foreach (Group group in DataStore.groups)
            {
                Console.WriteLine($"ID: {group.GroupID}, Ad: {group.GroupName}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem
{
    internal class Mentor
    {
        public int MentorID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        

        public void AddMentor()
        {
            Mentor newMentor = new Mentor();

            Console.Write("Mentorun ID-i daxil edin (2-200): ");
            newMentor.MentorID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mentorun adini daxil edin: ");
            newMentor.Name = Console.ReadLine();

            Console.Write("Mentorun soyadini daxil edin: ");
            newMentor.Surname = Console.ReadLine();

            DataStore.mentors.Add(newMentor);
            Console.WriteLine("Mentor elave edildi!");
        }

        public void ModifyMentor()
        {
            Console.Write("Deyismek istediyiniz mentorun ID-i daxil edin: ");
            int ID = int.Parse(Console.ReadLine());

            Mentor mentor = DataStore.mentors.Find(m => m.MentorID == ID);
            if (mentor != null)
            {
                Console.Write("Yeni adi daxil edin: ");
                mentor.Name = Console.ReadLine();

                Console.Write("Yeni soyadi daxil edin: ");
                mentor.Surname = Console.ReadLine();

                Console.WriteLine("Mentor melumatlari deyisdirildi!");
            }
            else
            {
                Console.WriteLine("Mentor tapilmadi!");
            }
        }

        public void RemoveMentor()
        {
            Console.Write("Silmək istədiyiniz mentorun no-sunu daxil edin: ");
            int no = int.Parse(Console.ReadLine());

            Mentor mentor = DataStore.mentors.Find(m => m.MentorID == no);
            if (mentor != null)
            {
                DataStore.mentors.Remove(mentor);
                Console.WriteLine("Mentor silindi!");
            }
            else
            {
                Console.WriteLine("Mentor tapilmadi!");
            }
        }

        public void DisplayMentor()
        {
            Console.WriteLine("Mentor melumatlari:");
            foreach (Mentor mentor in DataStore.mentors)
            {
                Console.WriteLine($"ID: {mentor.MentorID}, Ad: {mentor.Name}, Soyad: {mentor.Surname}");
            }
        }
    }
}

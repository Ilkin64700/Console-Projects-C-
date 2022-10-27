using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HosbitalManagmentTask.Models;
using HosbitalManagmentTask.Services;

namespace HosbitalManagmentTask
{
    class Program
    {
        static void Main(string[] args)
        {
            HosbitalManager hosbitalManager = new HosbitalManager();

            do
            {
                Console.WriteLine("Etmek Isdediyniz Emelliyyati Secin");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("1.1 Hekim Elave Et");
                Console.WriteLine("1.2 Hekimlerin Siyahisi");
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "1.1":
                        AddDoctor(hosbitalManager);
                        break;
                    case "1.2":
                        ShowList(hosbitalManager);
                        break;
                    default:
                        break;
                }

            } while (true);
        }

        public static void AddDoctor(HosbitalManager hosbitalManager)
        {
            Console.WriteLine("Hekimin Adini Daxil Et");
            string doctorName = Console.ReadLine();
            Console.WriteLine("Hekimin SoyAdini Daxil Et");
            string doctorSurName = Console.ReadLine();
            Console.WriteLine("Hekimin Ixtisasini Daxil Et");
            string doctorSpeciality = Console.ReadLine();
            Console.WriteLine("Hekimin Yasini Daxil Et");
            byte doctorage = 0;
            bool ageLoop = true;
            while (ageLoop)
            {
                try
                {
                    doctorage = byte.Parse(Console.ReadLine());
                    ageLoop = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Duzgun Yash Daxil Edin");
                }
            }

            Doctor doctor = new Doctor(doctorName, doctorSurName, doctorage, doctorSpeciality);

            hosbitalManager.AddDoctor(doctor);
        }

        public static void ShowList(HosbitalManager hosbitalManager)
        {
            foreach (Doctor item in hosbitalManager.Doctors)
            {
                Console.WriteLine(item);
            }
        }
    }
}

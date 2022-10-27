using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;

namespace _21042021
{
    class Program
    {

        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            hospital.Doctors.Add(new Doctor("Hikmet", "Abbasov", "goz hekimi"));
            hospital.Doctors.Add(new Doctor("Seynur", "Qulamov", "diz hekimi"));
            hospital.Doctors.Add(new Doctor("Dilare", "Hekimova", "dis hekimi"));
            hospital.Doctors.Add(new Doctor("Faride", "Qulamova", "urek hekimi"));
            hospital.Doctors.Add(new Doctor("Arzu", "Ceferov", "deri hekimi"));

            hospital.Patients.Add(new Patient("Eli", "Agayev", true));
            hospital.Patients.Add(new Patient("Kamil", "Memmedli", true));
            hospital.Patients.Add(new Patient("Vahid", "Aliyev", true));
            hospital.Patients.Add(new Patient("Nergiz", "Nusretzade", false));
            hospital.Patients.Add(new Patient("Seynur", "Memmedov", true));

            foreach (var item in hospital.SearchPatients("seynur"))
            {
                Console.WriteLine(item.Name + " " + item.Surname);
            }

            try
            {
                Doctor doctor = hospital.FindDoctor("UH1002");

                int[] ages = new int[1];

                Console.WriteLine(hospital.FindDoctor("GO1003").Name);

                Console.WriteLine(hospital.Patients[100]);

                var res = 45 / ages[0];

                Console.WriteLine(ages[2]);
            }

            catch (DoctorNotFoundException e)
            {
                Console.WriteLine("Nomre yanlisdir!");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("null error message: null deyer istifade etmeye cehd edilib");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("range error message: olmayan argumente muraciet edilib");
            }

            catch (Exception e)
            {
                Console.WriteLine("xeta bas verdi: " + e.Message);
            }



            //string name = "Seynur";

            //var result = name == null ? false : (name.Contains("s"));

            //if(name == null)
            //{
            //    result = false;
            //}
            //else
            //{
            //    result = name.Contains("s");
            //}


            DateTime dateTime = new DateTime();

            Console.WriteLine(dateTime);

            dateTime = dateTime.AddSeconds(40);
            dateTime = dateTime.AddMinutes(10);
            dateTime = dateTime.AddHours(5);
            dateTime = dateTime.AddMonths(2);
            dateTime = dateTime.AddYears(10);

            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine(dateTime.ToLongTimeString());
            Console.WriteLine(dateTime.ToShortDateString());
            Console.WriteLine(dateTime.ToShortTimeString());

            Console.WriteLine(dateTime.ToString("dddd dd/MM/yyyy HH:mm"));



            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");

            string dateStr;
            DateTime birthDate;

        enterDate:
            Console.WriteLine("Dogum tarixinizi daxil edin:");
            dateStr = Console.ReadLine();

            if (!DateTime.TryParse(dateStr, out birthDate))
            {
                goto enterDate;
            }
            Console.WriteLine("Heftenin gunu: " + birthDate.ToString("dddd"));


            string dayEn = birthDate.ToString("dddd");

            string dayAz = "";

            switch (dayEn)
            {
                case "Monday":
                    dayAz = "Bazarertesi";
                    break;
                case "Tuesday":
                    dayAz = "Cersenbeaxsami";
                    break;
                case "Wednesday":
                    dayAz = "Cersenbe";
                    break;
                case "Thursday":
                    dayAz = "Cumeaxsami";
                    break;
                case "Friday":
                    dayAz = "Cume";
                    break;
                case "Saturday":
                    dayAz = "Hestesonu";
                    break;
                case "Sunday":
                    goto case "Saturday";
                default:
                    goto enterDate;
            }

            Console.WriteLine("Heftenin gunu: " + dayAz);

            PhoneBook phoneBook = new PhoneBook();

            phoneBook[0] = "012-421-21-21";
            phoneBook[1] = "055-400-40-40";
            phoneBook[2] = "070-311-11-11";

            Console.WriteLine(phoneBook[0]);
            Console.WriteLine(phoneBook[1]);
            Console.WriteLine(phoneBook[2]);

            phoneBook[20] = "fdfds";
            phoneBook[0] = "dsfds";


        }
    }
}

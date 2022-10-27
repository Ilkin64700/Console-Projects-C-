using System;
using System.Collections.Generic;
using System.Text;

namespace _21042021
{
    class Hospital
    {
        public List<Doctor> Doctors = new List<Doctor>();
        public List<Patient> Patients = new List<Patient>();

        public List<Doctor> SearchDoctors(string str)
        {
            str = str.ToLower();
            return Doctors.FindAll(x => x.Speciality.ToLower().Contains(str) || x.No.ToLower().Contains(str) || (x.Name + " " + x.Surname).ToLower().Contains(str));
        }

        public List<Patient> SearchPatients(string str)
        {
            str = str.ToLower();
            return Patients.FindAll(x => x.No.ToLower().Contains(str) 
                         || (x.Diagnosis!=null? x.Diagnosis.ToLower().Contains(str):false)
                         || (x.Name + " " + x.Surname).ToLower().Contains(str));
        }

        public Doctor FindDoctor(string no)
        {
            var doctor =  Doctors.Find(x => x.No == no);

            if(doctor == null)
            {
                throw new DoctorNotFoundException($"{no} nomreli hekim sistemde mivcud deyil");
            }

            return doctor;
        }


        public List<Human> Search(string str)
        {
            List<Human> humans = new List<Human>();

            str = str.ToLower();
            List<Doctor> doctors = Doctors.FindAll(x => (x.Name + " " + x.Surname).ToLower().Contains(str));
            List<Patient> patients = Patients.FindAll(x => (x.Name + " " + x.Surname).ToLower().Contains(str));

            humans.AddRange(doctors);
            humans.AddRange(patients);

            return humans;
        }
    }
}

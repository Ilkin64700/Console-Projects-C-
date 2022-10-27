using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HosbitalManagmentTask.Interfaces;
using HosbitalManagmentTask.Models;

namespace HosbitalManagmentTask.Services
{
    class HosbitalManager : IHosbitalManager
    {
        public List<Doctor> Doctors { get; set; }

        public HosbitalManager()
        {
            Doctors = new List<Doctor>();
        }
        public void AddDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
        }
    }
}

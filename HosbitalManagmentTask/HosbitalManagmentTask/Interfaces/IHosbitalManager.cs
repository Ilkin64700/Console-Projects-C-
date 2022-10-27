using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HosbitalManagmentTask.Models;

namespace HosbitalManagmentTask.Interfaces
{
    interface IHosbitalManager
    {
        List<Doctor> Doctors { get; set; }

        void AddDoctor(Doctor doctor);
    }
}

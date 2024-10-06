using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class FieldService
    {
     public string JobID { get; set; }
        public Technician AssignedTechnician { get; set; }
        public string JobStatus { get; set; }

        public FieldService(string jobId)
        {
            JobID = jobId;
            JobStatus = "Scheduled"; // Default status
        }

        public void ScheduleTechnician(Technician technician)
        {
            AssignedTechnician = technician;
            JobStatus = "Technician Assigned";
            System.Console.WriteLine($"Technician {technician.Name} has been scheduled for Job ID {JobID}");
        }

        public void MonitorJobProgress()
        {
            // Logic to monitor the job's progress
            System.Console.WriteLine($"Monitoring progress for Job ID {JobID} assigned to Technician {AssignedTechnician?.Name}");
        }

    }
}

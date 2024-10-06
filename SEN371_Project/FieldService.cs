using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class FieldService : Record
    {
        private string jobID;
        private string technicianAssignment; 
        private string jobStatus;
        

         public string JobID
        {
            get { return jobID;}
            private set { jobID = value;} 
        }
    
        public string TechnicianAssignment
        {
            get { return technicianAssignment; }
            private set { technicianAssignment = value; }
        }

        
        public string JobStatus
        {
            get { return jobStatus; }
            private set { jobStatus = value; } 
        }

        public FieldService(string recordID, DateTime dateCreated, string description, string jobID,
                             string technicianAssignment, string jobStatus) :base(recordID, dateCreated, description);

        public void scheduleTechnician() { 
            // Implementation for scheduling a technician later in project
        }

        public void monitorJobProgress() { 
            // Implementation for monitoring job progress later in project
        }

        public void DisplayJobInfo()
        {
            // Call the base class method to display record info
            DisplayRecord();//base class method to display record info
            Console.WriteLine($"Job ID: {JobID}");
            Console.WriteLine($"Technician Assignment: {TechnicianAssignment}");
            Console.WriteLine($"Job Status: {JobStatus}");
        }
    }
}

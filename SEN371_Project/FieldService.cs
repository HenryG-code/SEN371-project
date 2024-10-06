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
        private string technicianAssignmnet;
        private string jobStatus;
        

         public string JobID
    {
        get { return jobID; }
        private set { jobID = value; } 

   
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
                             string technicianAssignment, string jobStatus) :base(recordID, dateCreated, description)

        public void scheduleTechnician() { }

        public void monitorJobProgress() { }

        public void DisplayJobInfo()
        {
            RecordInfo(); //base class method to display record info
        }

    }
}

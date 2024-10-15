using System;

namespace SEN371_Project
{
    internal class FieldService : Record
    {
        // Private fields
        private string jobID;
        private string technicianAssignment; 
        private string jobStatus;

        // Properties for encapsulation
        public string JobID
        {
            get { return jobID; }
            private set { jobID = value; } 
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

        // Constructor to initialize the FieldService object
        public FieldService(string recordID, DateTime dateCreated, string description, 
                            string jobID, string technicianAssignment, string jobStatus)
        : base(recordID, dateCreated, description)
        {
            JobID = jobID;
            TechnicianAssignment = technicianAssignment;
            JobStatus = jobStatus;
        }

        // Method to schedule a technician for a job
        public void ScheduleTechnician()
        {
            // Placeholder for scheduling a technician (will be implemented later)
            Console.WriteLine($"Technician {TechnicianAssignment} has been scheduled for Job ID {JobID}.");
        }

        // Method to monitor job progress
        public void MonitorJobProgress()
        {
            // Placeholder for job progress monitoring (will be implemented later)
            Console.WriteLine($"Monitoring progress of Job ID {JobID}. Current status: {JobStatus}");
        }

        // Method to display job information
        public void DisplayJobInfo()
        {
            // Call the base class method to display common record information
            DisplayRecord(); // Display common record info (from the base class)
            // Display field-specific information
            Console.WriteLine($"Job ID: {JobID}");
            Console.WriteLine($"Technician Assignment: {TechnicianAssignment}");
            Console.WriteLine($"Job Status: {JobStatus}");
        }
    }
}

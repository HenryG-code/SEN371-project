using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class Technician
    {
        private string technicianID;
        private string name;
        private string[] skillSet;
        private bool availability;

        public string TechnicianID
        {
            get { return technicianID; }
            private set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Technician ID cannot be null or empty.", nameof(value));
                technicianID = value;
            }
        }

        public string Name
        {
            get { return name; }
            private set 
            { 
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be null or empty.", nameof(value));
                name = value;
            }
        }

        public string[] SkillSet
        {
            get { return skillSet; }
            private set
            { 
                if (value == null || value.Length == 0)
                    throw new ArgumentException("Skill set cannot be null or empty.", nameof(value));
                skillSet = value;
            }
        }

        public bool Availability
        {
            get { return availability; }
            private set { availability = value; }
        }

        // Constructor
        public Technician(string technicianID, string name, string[] skillSet, bool availability)
        {
            TechnicianID = technicianID;
            Name = name;
            SkillSet = skillSet;
            Availability = availability;
        }

        public void UpdateJobStatus()
        {
            // Implementation for updating the job status
        }

        public void ReceiveJobAssignment()
        {
            // Implementation for receiving job assignments
            if (!Availability)
            {
                Console.WriteLine($"{Name} is not available for any new assignments.");
                return;
            }
            string jobDetails = "Sample Job Details"; // Define jobDetails variable
            Console.WriteLine($"{Name} has received the job assignment: {jobDetails}");
        }

        public void DisplayTechnicianInfo()
        {
            Console.WriteLine($"Technician ID: {TechnicianID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Skills: {string.Join(", ", SkillSet)}");
            Console.WriteLine($"Availability: {(Availability ? "Available" : "Not Available")}");
        }

        public override string ToString()
        {
            return $"Technician ID: {TechnicianID}, Name: {Name}, Skills: {string.Join(", ", SkillSet)}, Availability: {(Availability ? "Available" : "Not Available")}";
        }

    }

}

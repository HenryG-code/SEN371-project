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
        private set { technicianID = value; } 
    }


    public string Name
    {
        get { return name; }
        private set { name = value; } 
    }

    
    public string[] SkillSet
    {
        get { return skillSet; }
        private set { skillSet = value; } 
    }

  
    public bool Availability
    {
        get { return availability; }
        private set { availability = value; } 
    }


 public Technician(string technicianID, string name, string[] skillSet, bool availability)
    {
        
    }
        
        public void updateJobStatus() { }

        public void recieveJobAssignment() { }

    }
}

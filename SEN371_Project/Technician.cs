using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class Technician : Person
    {
        private string technicianID;
        private string name;
        private string[] skillSet;
        private bool availability;

         public List<Task> AssignedTasks { get; set; }

        public Technician(int id, string name, string phone) : base(id, name, phone)
        {
            AssignedTasks = new List<Task>();
        }

        public void AssignTask(Task task)
        {
            AssignedTasks.Add(task);
        }

        public void updateJobStatus() { }

        public void recieveJobAssignment() { }

    }
}

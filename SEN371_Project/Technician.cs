using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class Technician : Person
    {
        public string TechnicianID { get; set; }
        public string Name { get; set; }
        public string[] SkillSet { get; set; }
        public bool Availability { get; set; }

        public List<Task> AssignedTasks { get; set; }

        public Technician(int id, string technicianID, string name, string phone, bool availability) : base(id, name, phone)
        {
            TechnicianID = technicianID;
            Availability = availability;
            AssignedTasks = new List<Task>();
        }

        public void AssignTask(Task task)
        {
           if (!Availability)
            {
                throw new InvalidOperationException("Technician is not available to take new tasks.");
            }

            AssignedTasks.Add(task);
            System.Console.WriteLine($"Task {task.TaskID} assigned to Technician {TechnicianID}.");
        }

        public void updateJobStatus(Task task, string newStatus) { 
            task.UpdateStatus(newStatus);
            System.Console.WriteLine($"Job status for Task {task.TaskID} updated to {newStatus}.");
        }

        public void ReceiveJobAssignment(Task task)
        {
            AssignTask(task); // Reuse the AssignTask method
            System.Console.WriteLine($"Job assignment received for Task {task.TaskID}.");
        }

    }
}

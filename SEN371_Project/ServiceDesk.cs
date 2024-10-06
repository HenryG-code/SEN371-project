using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class ServiceDesk
    {
        private string[] serviceRequestList;
        private string communicationChannel;
        private string clientDetails;

        public void logServiceZRequest() { }
        
        private void assignTechnician() { }

        private void displayClientDetails() { }

        public void LogIssue(string issue, Client client)
        {
            // Logic to log the issue
            System.Console.WriteLine($"Issue logged for client {client.Name}: {issue}");
        }

        public void AssignTechnician(Technician tech, Task task)
        {
            tech.AssignTask(task);
            System.Console.WriteLine($"Task {task.TaskID} assigned to technician {tech.Name}");
        }

        public void EndInteraction(Client client)
        {
            // End interaction logic
            System.Console.WriteLine($"Interaction ended for client {client.Name}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class ServiceDesk
    {
       public List<string> ServiceRequestList { get; private set; }
        public string CommunicationChannel { get; set; }
        public string ClientDetails { get; set; }

        public void logServiceZRequest() { }
        
        private void assignTechnician() { }

        private void displayClientDetails() { }

       public ServiceDesk()
        {
            ServiceRequestList = new List<string>();
        }

        public void LogServiceRequest(string request, Client client)
        {
            ServiceRequestList.Add(request);
            System.Console.WriteLine($"Service request logged for client {client.ClientName}: {request}");
        }
        
        private void AssignTechnician(Technician technician, Task task)
        {
            technician.AssignTask(task);
            System.Console.WriteLine($"Task {task.TaskID} assigned to technician {technician.Name}");
        }

        private void DisplayClientDetails(Client client)
        {
            System.Console.WriteLine($"Client Details: ID={client.ID}, Name={client.ClientName}, Phone={client.Phone}");
        }

        public void EndInteraction(Client client)
        {
            // Logic to end interaction
            System.Console.WriteLine($"Interaction ended for client {client.ClientName}");
        }

    }
}

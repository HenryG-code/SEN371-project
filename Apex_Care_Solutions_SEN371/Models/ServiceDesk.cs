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

        public string[] ServiceRequestList
        {
            get { return serviceRequestList; }
            private set { serviceRequestList = value; }
        }

        public string CommunicationChannel
        {
            get { return communicationChannel; }
            private set { communicationChannel = value; }
        }

        public string ClientDetails
        {
            get { return clientDetails; }
            private set { clientDetails = value; }
        }

        public ServiceDesk(string[] serviceRequestList, string communicationChannel, string clientDetails)
        {

        }

        public void logServiceZRequest()
        {
            // To be implemented later
        }

        private void assignTechnician(string technicianID)
        {
            // Logic to assign a technician
            Console.WriteLine($"Technician {technicianID} assigned.");
        }

        private void displayClientDetails()
        {
            Console.WriteLine($"Client Details: {ClientDetails}");
        }


    }
}

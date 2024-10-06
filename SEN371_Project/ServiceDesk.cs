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

        public void logServiceZRequest() { 

        }
        
        private void assignTechnician() {

         }

        private void displayClientDetails() { 
            
        }


    }
}

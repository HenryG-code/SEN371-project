using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class Client:Record
    {
        private string clientID;
        private string clientName;
        private string[] serviceHistory;
        private string contractStatus;
        private int priority;
        private bool flagged = false;

            public string ClientID
        {
            get { return clientID; }
            private set { clientID = value; } 
        }

        public string ClientName
        {
            get { return clientName; }
            private set { clientName = value; } 
        }

        public string[] ServiceHistory
        {
            get { return serviceHistory; }
            private set { serviceHistory = value; }
        }

        
        public string ContractStatus
        {
            get { return contractStatus; }
            private set { contractStatus = value; } 
        }

        public int Priority
        {
            get { return priority; }
            private set { priority = value; } 
        }

        public bool Flagged
        {
           get {return flagged;}
           private set {flagged = value;}
        }


        public Client (string recordId, DateTime dateCreated, string description, string clientID, string clientName, string[] serviceHistory, string contractStatus, int priority)
        : base(recordId, dateCreated, description)
        {
            ClientID = clientID;
            ClientName = clientName;
            ServiceHistory = serviceHistory;
            ContractStatus = contractStatus;
            Priority = priority;
        }

        public void updateClientRecord(string newContractStatus, int newPriority) { 
            // Implementation for updating the client's record
            ContractStatus = newContractStatus;
            Priority = newPriority;
            Console.WriteLine($"Client record for {ClientName} updated: Contract Status = {ContractStatus}, Priority = {Priority} ");
        }

        public void flagClient() { 
             // Implementation for flagging the client
             flagged = true;
            Console.WriteLine($"Client {ClientName} flagged for review.");
        }


    }
}

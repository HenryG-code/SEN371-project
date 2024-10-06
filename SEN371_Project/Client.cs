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

     public int priority
    {
        get { return priority; }
        private set { priority = value; } 
    }
    

        public Client(string recordId, DateTime dateCreated, string description, string clientID, string clientName, string serviceHistory, string contractStatus, int priority)
        : base(recordId, dateCreated, description)
        {

        }

        public void updateClientRecord() { }

        public void flagClient() { }


    }
}

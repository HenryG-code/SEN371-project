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
        private string clientName;//think we should change this to clientname
        private string[] serviceHistory;
        private string contractStatus;
        private int priority;

        public Client(string recordId, DateTime dateCreated, string description, string clientID, string clientName, string serviceHistory, string contractStatus, int priority)
        : base(recordId, dateCreated, description)
        {

        }

        public void updateClientRecord() { }

        public void flagClient() { }


    }
}

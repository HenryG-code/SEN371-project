using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class Client:Person
    {
        /**
        private string clientID;
        private string clientName;//think we should change this to clientname
        private string[] serviceHistory;
        private string contractStatus;
        private int priority;
        **/
        public List<string> ServiceHistory { get; set; }
        public List<Contract> Contracts { get; set; }

        public Client(int id, string clientName, string phone) : base(id, clientName, phone)
        {
          ServiceHistory = new List<string>();
          Contracts = new List<Contract>();  
        }

            public void AddServiceHistory(string history)
        {
            ServiceHistory.Add(history);
        }

        public void updateClientRecord() { }

        public void flagClient() { }


    }
}

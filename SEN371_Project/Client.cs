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

        public bool IsFlagged { get; set; }
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

        public void updateClientRecord() { 

            this.Phone = newPhone;
            Console.WriteLine($"Client's phone number has been updated to: {newPhone}");
        }

        public void flagClient() { 

            IsFlagged = true;
            Console.WriteLine($"Client {Name} has been flagged due to contract issues.");
        }

         public void AddContract(Contract contract)
        {
            Contracts.Add(contract);
            Console.WriteLine($"Contract {contract.ContractID} added for client {Name}.");
        }

        public void RemoveContract(Contract contract)
        {
            Contracts.Remove(contract);
            Console.WriteLine($"Contract {contract.ContractID} removed for client {Name}.");
        }

        public void ViewActiveContracts()
        {
            foreach (var contract in Contracts)
            {
                Console.WriteLine($"Active Contract: {contract.ContractID} - Status: {contract.Status}");
            }
        }


    }
}

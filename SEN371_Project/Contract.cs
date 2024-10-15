using System;

namespace SEN371_Project
{
    internal class Contract : Record
    {
        private string contractID;
        private string serviceLevel;
        private DateTime renewalDate;
        private int serviceUsage;

        // Properties
        public string ContractID
        {
            get { return contractID; }
            private set { contractID = value; }
        }

        public string ServiceLevel
        {
            get { return serviceLevel; }
            private set { serviceLevel = value; }
        }

        public DateTime RenewalDate
        {
            get { return renewalDate; }
            private set { renewalDate = value; }
        }

        public int ServiceUsage
        {
            get { return serviceUsage; }
            private set { serviceUsage = value; }
        }

        // Constructor
        public Contract(string recordId, DateTime dateCreated, string description, string contractID, string serviceLevel, DateTime renewalDate, int serviceUsage)
        : base(recordId, dateCreated, description)
        {
            ContractID = contractID;
            ServiceLevel = serviceLevel;
            RenewalDate = renewalDate;
            ServiceUsage = serviceUsage;
        }

        // Method to display contract details
        public void ViewContractDetails()
        {
            Console.WriteLine($"Contract ID: {ContractID}");
            Console.WriteLine($"Service Level: {ServiceLevel}");
            Console.WriteLine($"Renewal Date: {RenewalDate.ToShortDateString()}");
            Console.WriteLine($"Service Usage: {ServiceUsage} hours");
        }

        // Method to renew the contract
        public void RenewContract(int additionalUsage)
        {
            RenewalDate = RenewalDate.AddYears(1);  // Assume renewal extends the contract by a year
            ServiceUsage += additionalUsage;
            Console.WriteLine($"Contract renewed! New Renewal Date: {RenewalDate.ToShortDateString()}, Updated Service Usage: {ServiceUsage}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Contract instance
            Contract contract = new Contract(
                "REC002",
                DateTime.Now,
                "Client contract for service level and usage",
                "CON001",
                "Gold",
                DateTime.Now.AddYears(1),
                100
            );

            // View the contract details
            contract.ViewContractDetails();

            // Renew the contract and update the usage
            contract.RenewContract(50);  // Adds 50 hours to service usage

            // View the updated contract details
            contract.ViewContractDetails();
        }
    }
}

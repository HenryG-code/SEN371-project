using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class Contract
    {
        // Properties
        public int ContractID { get; set; }
        public string ServiceLevel { get; set; }
        public DateTime RenewalDate { get; set; }
        public int ServiceUsage { get; set; }
        public bool RenewalStatus { get; set; }
        // Constructor
        public Contract(int id, string serviceLevel, DateTime renewalDate, bool status, int serviceUsage)
        {
            ContractID = id;
            ServiceLevel = serviceLevel;
            RenewalDate = renewalDate;
            RenewalStatus = status;
            ServiceUsage = serviceUsage;
        }

        // Method to view contract details
        public void ViewContractDetails()
        {
            Console.WriteLine($"Contract ID: {ContractID}");
            Console.WriteLine($"Service Level: {ServiceLevel}");
            Console.WriteLine($"Renewal Date: {RenewalDate.ToShortDateString()}");
            Console.WriteLine($"Renewal Status: {(RenewalStatus ? "Active" : "Inactive")}");
            Console.WriteLine($"Service Usage: {ServiceUsage} times");
        }

         // Method to renew contract
        public void RenewContract()
        {
            // Logic to automate contract renewal
            RenewalStatus = true; // Set renewal status to active
            RenewalDate = DateTime.Now.AddYears(1); // Example: renew for one year
            Console.WriteLine($"Contract {ContractID} has been renewed until {RenewalDate.ToShortDateString()}");
        }
    }
}

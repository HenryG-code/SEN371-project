using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class Contract
    {
        /**
        private string contractID;
        private string serviceLevel;
        private DateTime renewalDate;
        private int serviceUsage;
        **/

        public int ContracterID {get; set;}

        private string ServiceLevel{get; set;}

        private bool RenewalStatus{get; set;}

        public Contract(int id, string ServiceLevel, bool status)
        {
          ContracterID = id;
          ServiceLevel = ServiceLevel;
          renewalStatus = status; 
        }

        public void viewContractDetails() {
          // Logic to track contract performance
        System.Console.WriteLine($"Tracking performance for Contract {ContractID}");  
         }

        public void renewContract() { 

         // Logic to automate contract renewal
        System.Console.WriteLine($"Contract {ContractID} has been renewed automatically");
        }


    }
}

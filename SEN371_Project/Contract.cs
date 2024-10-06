using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class Contract : Record
    {
        private string contractID;
        private string serviceLevel;
        private DateTime renewalDate;
        private int serviceUsage;

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
        

        public Contract(string recordId, DateTime dateCreated, string description, string contractId, sting serviceLevel, DateTime renewalDate, int serviceUsage)
        : base(recordId, dateCreated, description)
        {
            ContractID = contractId;
            ServiceLevel = serviceLevel;
            RenewalDate = renewalDate;
            ServiceUsage = serviceUsage;
        }

        public void viewContractDetails() { 

        }

        public void renewContract() { 
            
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class Contract:Record
    {
        private string contractID;
        private string serviceLevel;
        private DateTime renewalDate;
        private int serviceUsage;

        public Contract(string recordId, DateTime dateCreated, string description, string contractId, sting serviceLevel, DateTime renewalDate, int serviceUsage)
        : base(recordId, dateCreated, description)
        {

        }

        public void viewContractDetails() { }

        public void renewContract() { }


    }
}

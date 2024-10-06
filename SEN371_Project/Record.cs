using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class Record
    {
       public string recordID;
       public DateTime dateCreated;
       public string description;
        

        public string RecordID
    {
        get { return recordID; }
        private set { recordID = value; } 
    }

    
    public DateTime DateCreated
    {
        get { return dateCreated; }
        private set { dateCreated = value; } 
    }

   
    public string Description
    {
        get { return description; }
        private set { description = value; } 
    }

        public Record(string recordID, DateTime dateCreated, string description)
        {
            
        }

      public void DisplayRecord()
      {
          
      }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class Record
    {
        public string RecordID { get; private set; }
        public DateTime DateCreated { get; private set; }
        public string Description { get; private set; }

        public Record(string recordID, DateTime dateCreated, string description)
        {
          RecordID = recordID;
          DateCreated = dateCreated;
          Description = description; 
        }

      public void DisplayRecord()
      {
        Console.WriteLine($"Record ID: {RecordID}");
        Console.WriteLine($"Date Created: {DateCreated}");
        Console.WriteLine($"Description: {Description}"); 
      }

      public void UpdateDescription(string newDescription)
        {
            if (string.IsNullOrWhiteSpace(newDescription))
                throw new ArgumentException("Description cannot be null or empty.", nameof(newDescription));

            Description = newDescription;
            Console.WriteLine("Description updated successfully.");
        }

        public override string ToString()
        {
            return $"Record ID: {RecordID}, Date Created: {DateCreated:yyyy-MM-dd HH:mm:ss}, Description: {Description}";
        }

    
    }

}

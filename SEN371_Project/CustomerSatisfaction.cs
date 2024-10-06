using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class CustomerSatisfaction
    {
        private string feedbackID;
        private string clientID; 
        private float satisfactionScore; 
        private string complaintDetails; 

            public string FeedbackID
        {
            get { return feedbackID; }
            private set { feedbackID = value; }
        }

        public string ClientID
        {
            get { return clientID; }
            private set { clientID = value; }
        }

        public float SatisfactionScore
        {
            get { return satisfactionScore; }
            private set { satisfactionScore = value; }
        }

        public string ComplaintDetails
        {
            get { return complaintDetails; }
            private set { complaintDetails = value; }
        }

        // Constructor
        public CustomerSatisfaction(string feedbackID, string clientID, float satisfactionScore, string complaintDetails)
        {
            FeedbackID = feedbackID;
            ClientID = clientID;
            SatisfactionScore = satisfactionScore;
            ComplaintDetails = complaintDetails;
        }

        // Method to send a survey
        public void sendSurvey()
        {
           // Implementation for sending a survey to clients
            Console.WriteLine($"Survey sent to client {ClientID}.");
        }

        public void logComplaint()
        {
            // Implementation for logging a complaint
            Console.WriteLine($"Complaint logged for client {ClientID}: {ComplaintDetails}");
        }

        public void analyzeSentiment()
        {
            // Implementation for analyzing sentiment based on the satisfaction score
        }

        // Method to display feedback information
        public void DisplayFeedbackInfo()
        {
            Console.WriteLine($"Feedback ID: {FeedbackID}");
            Console.WriteLine($"Client ID: {ClientID}");
            Console.WriteLine($"Satisfaction Score: {SatisfactionScore}");
            Console.WriteLine($"Complaint Details: {ComplaintDetails}");
        }


    }
}

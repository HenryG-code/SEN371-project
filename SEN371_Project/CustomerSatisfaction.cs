using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN371_Project
{
    internal class CustomerSatisfaction
    {
        public string FeedbackID { get; set; }
        public string ClientID { get; set; }
        public float SatisfactionScore { get; set; }
        public string ComplaintDetails { get; set; }

        // Constructor to initialize the CustomerSatisfaction object
        public CustomerSatisfaction(string feedbackId, string clientId, float satisfactionScore, string complaintDetails)
        {
            FeedbackID = feedbackId;
            ClientID = clientId;
            SatisfactionScore = satisfactionScore;
            ComplaintDetails = complaintDetails;
        }

        public void SendSurvey()
        {
            // Logic to send a customer satisfaction survey
            System.Console.WriteLine($"Survey sent to Client ID {ClientID} for Feedback ID {FeedbackID}.");
        }

        public void LogComplaint(string complaint)
        {
            ComplaintDetails = complaint;
            // Logic to log the complaint
            System.Console.WriteLine($"Complaint logged for Client ID {ClientID}: {complaint}");
        }

        public void AnalyzeSentiment()
        {
            // Logic to analyze sentiment based on satisfaction score or complaint details
            System.Console.WriteLine($"Analyzing sentiment for Client ID {ClientID} with score {SatisfactionScore}.");
        }

    }
}

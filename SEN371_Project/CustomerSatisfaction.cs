using System;

namespace SEN371_Project
{
    internal class CustomerSatisfaction
    {
        // Private fields
        private string feedbackID;
        private string clientID; 
        private float satisfactionScore; 
        private string complaintDetails; 

        // Properties to encapsulate the fields
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

        // Constructor to initialize CustomerSatisfaction object
        public CustomerSatisfaction(string feedbackID, string clientID, float satisfactionScore, string complaintDetails)
        {
            FeedbackID = feedbackID;
            ClientID = clientID;
            SatisfactionScore = satisfactionScore;
            ComplaintDetails = complaintDetails;
        }

        // Method to simulate sending a survey to a client
        public void SendSurvey()
        {
            // Simulated survey sending functionality
            Console.WriteLine($"Survey sent to client {ClientID}.");
        }

        // Method to log a complaint from a client
        public void LogComplaint()
        {
            // Simulated complaint logging functionality
            Console.WriteLine($"Complaint logged for client {ClientID}: {ComplaintDetails}");
        }

        // Method to analyze sentiment based on satisfaction score
        public void AnalyzeSentiment()
        {
            // A basic implementation to analyze sentiment from satisfaction score
            string sentiment;
            if (SatisfactionScore >= 4.5)
            {
                sentiment = "Highly Satisfied";
            }
            else if (SatisfactionScore >= 3.0)
            {
                sentiment = "Satisfied";
            }
            else if (SatisfactionScore >= 2.0)
            {
                sentiment = "Dissatisfied";
            }
            else
            {
                sentiment = "Highly Dissatisfied";
            }

            Console.WriteLine($"Client {ClientID}'s sentiment analysis: {sentiment}");
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

    // Example usage of the class in the Main method
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new CustomerSatisfaction object
            CustomerSatisfaction feedback = new CustomerSatisfaction(
                "FB001",
                "CL001",
                4.2f,
                "Delayed response from technical support"
            );

            // Display feedback information
            feedback.DisplayFeedbackInfo();

            // Log a complaint
            feedback.LogComplaint();

            // Send a survey to the client
            feedback.SendSurvey();

            // Analyze the sentiment based on the satisfaction score
            feedback.AnalyzeSentiment();
        }
    }
}

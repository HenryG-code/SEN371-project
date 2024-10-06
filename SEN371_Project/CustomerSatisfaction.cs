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
        private string clientsID;
        private float stisfactionScore;
        private string complaintDetials;


         public string FeedbackID
    {
        get { return feedbackID; }
        private set { feedbackID = value; } 
    }


    public string ClientsID
    {
        get { return clientsID; }
        private set { clientsID = value; } 
    }

 
    public float SatisfactionScore
    {
        get { return satisfactionScore; }
        private set { satisfactionScore = value; } 
    }

  
    public string ComplaintDetails
    {
        get { return complaintDetails; }
        private set { complaintDetails = value; } //
    }


    public Feedback(string feedbackID, string clientsID, float satisfactionScore, string complaintDetails)
    {
      
    }


        public void sendSurvey()
        {
           
        }

        public void logComplaint()
        {

        }

        public void analyzeSentiment()
        {

        }


    }
}

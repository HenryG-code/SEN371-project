public class Task
{
    public int TaskID { get; set; }
    public string JobStatus { get; set; }

    // Constructor
    public Task(int taskId, string status = "Pending")//Default status
    {
        TaskID = taskId;
        JobStatus = status;
    }

    public void UpdateStatus(string newStatus)
    {
        if (string.IsNullOrWhiteSpace(newStatus))
        {
            throw new ArgumentException("Status cannot be null or empty.", nameof(newStatus));
        }

        JobStatus = newStatus;
        System.Console.WriteLine($"Task {TaskID} status updated to {JobStatus}");
    }
}
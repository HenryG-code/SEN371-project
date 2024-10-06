public class Task
{
    public int TaskID { get; set; }
    public string JobStatus { get; set; }

    public Task(int taskId, string status)
    {
        TaskID = taskId;
        JobStatus = status;
    }

    public void UpdateStatus(string newStatus)
    {
        JobStatus = newStatus;
        System.Console.WriteLine($"Task {TaskID} status updated to {JobStatus}");
    }
}
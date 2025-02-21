public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment()
    {
        _studentName = "Unknown";
        _topic = "Unknown";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public void GetSummary()
    {
        Console.WriteLine("Student Name: " + _studentName);
        Console.WriteLine("Topic: " + _topic);
    }


}
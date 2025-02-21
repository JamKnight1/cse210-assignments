public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public void GetHomeworkList()
    {
        GetSummary();
        Console.WriteLine("Textbook Section: " + _textbookSection);
        Console.WriteLine("Problems: " + _problems);

    }
}
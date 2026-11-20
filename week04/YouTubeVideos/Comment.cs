public class Comment
{
    public string _commenterName;
    public string _commentText;

    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_commenterName}");
        Console.WriteLine($"Comment: {_commentText}");
        Console.WriteLine();
    }
}

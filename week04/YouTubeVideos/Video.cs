public class Video
{
    public string _title;
    public string _author;
    public int _length;

    //public Comment _commenterName;
    //public Comment _commentText;
    public List<Video> _videos = new List<Video>();
    public List<Comment> _comments = new List<Comment>();
    //public List<Comment> _commentsvid2 = new List<Comment>();
    //public List<Comment> _commentsvid3 = new List<Comment>();
    //public List<Comment> _numberOfComments = new List<Comment>();


    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Channel: {_author}");
        Console.WriteLine($"Length (in seconds): {_length}");
        Console.WriteLine($"Number of Comments: {ReturnNumberOfComments()}");
        Console.WriteLine();
    }

    public void ReturnVideos()
    {
        Console.WriteLine("Videos:");
        Console.WriteLine();
        foreach (Video video in _videos)
        {   
            video.DisplayVideo();
            Console.WriteLine("Comments: ");
            Console.WriteLine();
            video.ReturnComments();
            Console.WriteLine();
        }
    }
    public void ReturnComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public int ReturnNumberOfComments()
    {
        return _comments.Count;
    }   

    //public void ReturnComments2()
    //{
    //    foreach (Comment comment in _commentsvid2)
    //    {
    //        comment.DisplayComment();
    //    }       
    //}  
    //public void ReturnNumberOfComments2()
    //{
    //    Console.WriteLine(_commentsvid2.Count);     
    //}    
    //public void ReturnComments3()
    //{
    //    foreach (Comment comment in _commentsvid3)
    //    {
    //        comment.DisplayComment();
    //    }       
    //}  
    //public void ReturnNumberOfComments3()
    //{
    //    Console.WriteLine(_commentsvid1.Count);
    //}
}
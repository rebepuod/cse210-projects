public class Video
{
public string _title;
public string _author;
public double _lenght;
public List<Comment> _comments = new List<Comment>();



public int NumberOfComments()
{
    int number = _comments.Count();

    return number;
}

public void AddEntry(Comment newComments)
{
    _comments.Add(newComments);
}

public void DisplayVideo()
{
    Console.WriteLine($"\n{_title} | {_author} | {_lenght} min | Comments: {NumberOfComments()}\n");
    DisplayComments();
}

public void DisplayComments()
{
    foreach(Comment comment in _comments)
    {
        comment.Display();
    }
}




















}
public class Library
{
    int ID;
    string Title;

    public Library(int id, string title)
    {
        ID = id;
        Title = title;
    }
    public string Info()
    {
        return $"ID = {ID}, Title = {Title}";
    }
}
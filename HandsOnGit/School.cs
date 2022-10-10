namespace HandsOnGit;

internal class School
{
    public string name { get; set; }
    public string address { get; set; }
    public int id { get; set; }

    public School()
    {
    }

    public School(string name2, string address2, int id2)
    {
        name = name2;
        address = address2;
        id = id2;
    }
    public override string? ToString()
    {
        return $"Name: {name}, Address: {address}, Id: {id}";
    }
}

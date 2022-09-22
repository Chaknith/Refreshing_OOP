public class BlogWriter : Writer
{
    public BlogWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Vlog()
    {
        Console.WriteLine("I am doing Vlog about blog.");
    }

    public override void Write()
    {
        Console.WriteLine("I am writing blog.");
    }
}
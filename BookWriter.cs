public class BookWriter : Writer
{
    public BookWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Vlog()
    {
        Console.WriteLine("I am doing Vlog about book.");
    }

    public override void Write()
    {
        Console.WriteLine("I am writing book.");
    }
}
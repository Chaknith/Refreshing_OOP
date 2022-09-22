public class OmniaClubPromoter : Promoter
{
    public OmniaClubPromoter(string firstName, string lastName, string cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    protected override void fristStep()
    {
        Console.WriteLine("Share with friends.");
    }

    protected override void secondStep()
    {
        Console.WriteLine("Use Facebook ads to promote.");
    }
}
public class XSClubPromoter : Promoter, IVlogger, IBodyBuilder
{
    public XSClubPromoter(string firstName, string lastName, string cellPhone) : base(firstName, lastName, cellPhone)
    {
    }

    public void Vlog()
    {
        Console.WriteLine("I am doing Vlog about XS club.");
    }
    public void Workout()
    {
        Console.WriteLine("I am working out.");
    }
    protected override void fristStep()
    {
        Console.WriteLine("Share with Instagram followers.");
    }
    protected override void secondStep()
    {
        Console.WriteLine("Use Google AdWords to promote.");
    }
}
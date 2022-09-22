// See https://aka.ms/new-console-template for more information

public class Program
{
    static void Main(string[] args)
    {
        List<Promoter> list1 = new List<Promoter>(){new XSClubPromoter("Jon", "Jones", "6175555555"),
        new XSClubPromoter("Jack", "Son", "6175555544"),new OmniaClubPromoter("Luck", "Ki", "6175553555")};

        List<Writer> list2 = new List<Writer>(){new BookWriter("Daniel", "Smith"),
        new BookWriter("Tony", "Neo"),new BlogWriter("Stark", "Tank")};

        List<IBodyBuilder> list3 = new List<IBodyBuilder>(){new XSClubPromoter("Jon", "Jones", "6175555555"),
        new XSClubPromoter("Jack", "Son", "6175555544")};

        List<IVlogger> list4 = new List<IVlogger>(){new XSClubPromoter("Jon", "Jones", "6175555555"),
        new BlogWriter("Hawk", "Tank")};

        foreach (Promoter promoter in list1)
        {
            promoter.Promote();
        }

        foreach (Writer writer in list2)
        {
            writer.Write();
        }

        foreach (IBodyBuilder bodyBuilder in list3)
        {
            bodyBuilder.Workout();
        }

        foreach (IVlogger vlogger in list4)
        {
            vlogger.Vlog();
        }
    }
}
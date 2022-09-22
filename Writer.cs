public abstract class Writer : IVlogger
{
    private string _firstName;
    private string _lastName;

    public string AuthorBio
    {
        get
        {
            return string.Format("My name is {0} {1}", this._firstName, this._lastName);
        }
    }

    public Writer(string firstName, string lastName)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    public abstract void Write();
    public abstract void Vlog();
}
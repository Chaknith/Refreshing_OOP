public abstract class Promoter
{
    private string _firstName;
    private string _lastName;
    private string _cellPhone;

    public string MyBusinessCard
    {
        get
        {
            return string.Format("{0} {1} {2}", this._firstName, this._lastName, this._cellPhone);
        }
    }

    public Promoter(string firstName, string lastName, string cellPhone)
    {
        this._firstName = firstName;
        this._lastName = lastName;
        this._cellPhone = cellPhone;
    }

    public void Promote()
    {
        this.fristStep();
        this.secondStep();
    }

    protected abstract void fristStep();
    protected abstract void secondStep();
}
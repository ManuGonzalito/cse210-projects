public class Job
{
    public string _company = "";
    public string _jobTittle = "";
    public int _startYear;
    public int _endYear;

    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTittle} ({_company}) {_startYear}-{_endYear}");
    }
}
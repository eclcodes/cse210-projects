// Making job class

using System.ComponentModel.DataAnnotations;

public class Job
{
    // Variables of company name, job title, start date, end date

    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

   public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

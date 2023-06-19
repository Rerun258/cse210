public class Job{
    string _company;
    string _jobTitle;
    int _startYear;
    int _endYear; 


    Job(string company, string jobTitle, int startYear, int endYear){
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }


    public void display(){
        Console.WriteLine($"Job Title: {_company}, Start Year - End Year: {_startYear}-{_endYear}");
    }
    
}
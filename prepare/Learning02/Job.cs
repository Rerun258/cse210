public class Job{
    string _company;
    string _jobTitle;
    int _startYear;
    int _endYear; 


    public void display(){
        Console.WriteLine($"Job Title: {_company}, Start Year - End Year: {_startYear}-{_endYear}");
    }
    
}
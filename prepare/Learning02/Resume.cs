public class Resume{
    public string _name;
    public List<Job> _jobs;

    public void display(){
        foreach (Job job in _jobs){
            job.display();
        }
    }



}
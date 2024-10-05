// Making Resume class

public class Resume
{
    // Variables name and jobs
    public string _name;

    // Initializing list
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // Looping for every job
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}
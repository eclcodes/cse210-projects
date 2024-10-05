using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // Instances of Job class
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2017;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._company = "Nintendo";
        job2._jobTitle = "Lead Designer";
        job2._startYear = 2020;
        job2._endYear = 2024;

        //job1.Display();
        //job2.Display();

        // Instance of Resume class
        Resume myResume = new Resume();
        myResume._name = "Emma Loveless";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
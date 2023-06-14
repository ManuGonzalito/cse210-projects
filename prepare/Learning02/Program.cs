using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTittle = ".NET Developer";
        job1._company = "Microsoft";
        job1._startYear = 2023;
        job1._endYear = 2040;

        Console.WriteLine();
        // Console.WriteLine(job1._company);
        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "ASAP Consulting";
        job2._jobTittle = "PHP Developer";
        job2._startYear = 2019;
        job2._endYear = 2023;

        // Console.WriteLine(job2._company);
        // job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Manuel González";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Console.WriteLine(myResume._jobs[0]._jobTittle);
        myResume.DisplayResume();
    }
}
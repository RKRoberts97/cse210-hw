using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Nintendo";
        job1._jobTitle = "Data Scientist";
        job1._startyear = 2019;
        job1._endyear = 2020;

        Job job2 = new Job();
        job2._company = "BYUI";
        job2._jobTitle = "Professor";
        job2._startyear = 2021;
        job2._endyear = 2024;

        Resume aResume = new Resume();
        aResume._name = "Russell Roberts";
        aResume._jobs.Add(job1);
        aResume._jobs.Add(job2);
        aResume.Display();
        



    }
}
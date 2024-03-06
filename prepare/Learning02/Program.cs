using System;

class Program
{
    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2018;
        job1._endYear = 2019;
        
        Job job2 = new Job();
        job2._company = "Facebook";
        job2._jobTitle = "Social Media Manager";
        job2._startYear = 2019;
        job2._endYear = 2021;

        Resume applicant = new Resume();
        applicant._name = "Eiron Araga";
        applicant._jobs.Add(job1);
        applicant._jobs.Add(job2);
        applicant.Display();



    }
}
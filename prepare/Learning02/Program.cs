using System;

class Program
{
static void Main(string[] args)
{
    Job job1 = new Job();
    job1._company = "Microsoft";
    job1._jobTitle = "Software Engineer";
    job1._startYear = 2020;
    job1._endYear = 2022;

    Job job2 = new Job();
    job2._company = "Apple";
    job2._jobTitle = "Software Developer";
    job2._startYear = 2022;
    job2._endYear = 2024;

   // DisplayCompany(job1);
   // DisplayCompany(job2);

    Resume myResume = new Resume();
    myResume._name = "Brian Timba";

    myResume._jobs.Add(job1);
    myResume._jobs.Add(job2);

   // DisplayResume(myResume);
   myResume.Display();
  
}
static void DisplayCompany(Job the_job)
{
    Console.WriteLine($"{the_job._jobTitle} ({the_job._company}) {the_job._startYear}-{the_job._endYear}");
}

static void DisplayResume(Resume the_resume)
{
    Console.WriteLine($"{the_resume._name}");
}

static void DisplayMyResume(Resume myResume)
{
    Console.WriteLine($"{myResume._jobs[0]._jobTitle}");
}
}
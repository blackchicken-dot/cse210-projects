using System;
using System.Collections.Generic;

class Program 
{
    static void Main() 
    {
        Resume myResume = new Resume();
        myResume._name = "Ugochukwu Onunkwo";

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Avcera Digital Tech";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "VitalTech";
        job2._startYear = 2022;
        job2._endYear = 2023;

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
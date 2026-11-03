
Job job1 = new Job();
job1._company = "Microsoft";
job1._jobTitle = "Software Engineer";
job1._startYear = 2019;
job1._endYear = 2022;
//job1.DisplayCompany(); This line was used in testing the company attributes.
//job1.DisplayJob();
Job job2 = new Job();
job2._company = "Apple";
job2._jobTitle = "Manager";
job2._startYear = 2022;
job2._endYear = 2023;
//job2.DisplayCompany(); This line was used in testing the company attributes.
//job2.DisplayJob();
Resume myresume = new Resume();
myresume._jobs.Add(job1);
myresume._jobs.Add(job2);

myresume._name = "Allison Rose";
myresume.DisplayJobs();




Assignment a1 = new Assignment("Peter Parker", "Pre-AP Calculus"); //Lines 1 and 2 are for step 3.
a1.GetSummary();
Console.WriteLine();
MathAssignment math1 = new MathAssignment("Peter Parker", "Pre-AP Calculus", "19.62", "1-11"); // Lines 4-6 are for step 5.
math1.GetSummary();
math1.GetHomeworkList();
Console.WriteLine();
WritingAssignment write1 = new WritingAssignment("Liz Allen", "US History", "The Three Main Causes of the American Revolution");
write1.GetSummary();
write1.GetWritingInformation();
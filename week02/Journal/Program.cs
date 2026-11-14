Console.WriteLine("Welcome to the Journal Program!");
Console.WriteLine();
Console.WriteLine("Main Menu: ");
Console.WriteLine("1. Write an entry");
Console.WriteLine("2. Display entry history");
Console.WriteLine("3. Load file");
Console.WriteLine("4. Save entry to file");
Console.WriteLine("5. Exit");
Console.Write("Select an option: ");
int selectedOption = 0;
selectedOption = int.Parse(Console.ReadLine());
while (selectedOption != 5)
{
    if (selectedOption == 1)
    {
        Entry newEntry = new Entry();
        DateTime _theCurrentDate = DateTime.Now;
        newEntry._date = _theCurrentDate.ToShortDateString();
        //ne.AddEntry(newEntry._date);
        Console.WriteLine();
        Console.WriteLine("Write an entry: ");
        Console.WriteLine();
        PromptGenerator prompt = new PromptGenerator();
        newEntry._promptText = prompt.GetRandomPrompt();
        //ne.AddEntry(_promptText);
        Console.WriteLine();
        newEntry._entryText = Console.ReadLine();
        Journal ne = new Journal();
        ne.AddEntry(newEntry);
        //ne.AddEntry(_entryText);
        //I think that the "newEntry" has to be in the same instance but I could be wrong.
        //I might need to add the prompt and the entry to the list of entries.     
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Main Menu: ");
        Console.WriteLine("1. Write an entry");
        Console.WriteLine("2. Display entry history");
        Console.WriteLine("3. Load file");
        Console.WriteLine("4. Save entry to file");
        Console.WriteLine("5. Exit");
        Console.Write("Select an option: ");
        selectedOption = int.Parse(Console.ReadLine());
    }
    else if (selectedOption == 2)
    {
        Console.WriteLine();
        Journal ae = new Journal();
        ae.DisplayAll();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Main Menu: ");
        Console.WriteLine("1. Write an entry");
        Console.WriteLine("2. Display entry history");
        Console.WriteLine("3. Load file");
        Console.WriteLine("4. Save entry to file");
        Console.WriteLine("5. Exit");
        Console.Write("Select an option: ");
        selectedOption = int.Parse(Console.ReadLine());
    }
    else if (selectedOption == 3)
    {
        Console.WriteLine();
        Console.WriteLine("Type in name of file: ");
        string filename = Console.ReadLine();
        Journal lf = new Journal();
        lf.LoadFromFile(filename);
        Console.WriteLine();
        Console.WriteLine("Main Menu: ");
        Console.WriteLine("1. Write an entry");
        Console.WriteLine("2. Display entry history");
        Console.WriteLine("3. Load file");
        Console.WriteLine("4. Save entry to file");
        Console.WriteLine("5. Exit");
        Console.Write("Select an option: ");
        selectedOption = int.Parse(Console.ReadLine());
    }
    else if (selectedOption == 4)
    {
        Console.WriteLine();
        Console.WriteLine("Type in name of file: ");
        string file = Console.ReadLine();
        Journal sf = new Journal();
        sf.SaveToFile(file);
        Console.WriteLine();
        Console.WriteLine("Main Menu: ");
        Console.WriteLine("1. Write an entry");
        Console.WriteLine("2. Display entry history");
        Console.WriteLine("3. Load file");
        Console.WriteLine("4. Save entry to file");
        Console.WriteLine("5. Exit");
        Console.Write("Select an option: ");
        selectedOption = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine();
Console.WriteLine("Come back and write another entry!");



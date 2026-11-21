using System;


Console.WriteLine("Scripture Memorizer:");
Console.WriteLine();
Reference r = new Reference("Malachi", 4, 5, 6);
Console.WriteLine(r.GetDisplayText());
Word verse1 = new Word("Behold, I will send you Elijah the prophet before the coming of the great and dreadful day of the LORD:");
Console.WriteLine(verse1.GetDisplayText());
Word verse2 = new Word("And he shall turn the heart of the fathers to the children, and the heart of the children to their fathers, lest I come and smite the earth with a curse.");
Console.WriteLine(verse2.GetDisplayText());
Console.WriteLine();
Console.WriteLine("Press enter to hide random words of the scripture for memorization or type in quit:");
string option = Console.ReadLine();
while (option != "quit")
{
    Console.WriteLine(r.GetDisplayText());
    Word scrip1 = new Word("Behold");
    scrip1.AddWord("Behold");

}
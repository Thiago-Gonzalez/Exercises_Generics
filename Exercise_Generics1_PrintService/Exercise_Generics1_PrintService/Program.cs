// See https://aka.ms/new-console-template for more information
using Exercise_Generics1_PrintService;

PrintService<string> printService = new PrintService<string>();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine()); 

for (int i=0; i < n; i++)
{
    string x = Console.ReadLine();
    printService.AddValue(x);
}

printService.Print();
Console.WriteLine("First: " + printService.First());
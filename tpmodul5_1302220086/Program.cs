// See https://aka.ms/new-console-template for more information
using System.Data;

class Datageneric()
{
    public void PrintData(string T)
    {
        Console.WriteLine("Data yang tersimpan adalah: " + T);
    }
}

class main()
{
    static void Main(string[] args)
    {
        Console.Write("Masukan Data: ");
        string T = Console.ReadLine();
        Console.WriteLine("Data yang tersimpan adalah: " + T);
    }
}
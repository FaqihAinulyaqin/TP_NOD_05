// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

class HaloGeneric()
{
    public void SapaUser(String x)
    {
        Console.WriteLine("Halo user " + x);
    }
}

class main()
{
    static void Main(String[] args)
    {
        Console.Write("Masukan nama anda: ");
        string x = Console.ReadLine();
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(x);
    }
}
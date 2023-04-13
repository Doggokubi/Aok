using Wyjatki.MyClass;

internal class Program
{
    private static void Main(string[] args)
    {
        //ZwierzakDomowy Reksio = new ZwierzakDomowy("Reksio", "Pies", new DateTime(2022,01,01));
        //Console.WriteLine(Reksio.ToString());

        //ZwierzakDomowy Azor = new ZwierzakDomowy("Azor", "NIE ŻYWY PIES", new DateTime(2024, 01, 10));
        //Console.WriteLine(Azor.ToString());

        //ZwierzakDomowy Filemon = new ZwierzakDomowy("Filemon", "Kot", new DateTime(1990, 12, 4));
        //Console.WriteLine(Filemon.ToString());

        RownanieKwadratowe f = new RownanieKwadratowe(1, 6, 5);
        Console.WriteLine(f.ToString());
        Console.ReadKey();
    }
}
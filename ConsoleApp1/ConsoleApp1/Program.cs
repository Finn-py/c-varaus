Console.WriteLine("Tervetuloa varausjärjestelmään!");
int valintaNro;
for (; ; )

{
    Console.WriteLine("näytä varaukset [1]");
    Console.WriteLine("Varaa vuoro  [2]");
    Console.WriteLine("Anna palautetta [3]");
    Console.WriteLine("Sammuta [0]");
    Console.WriteLine("Valitse valikosta haluttu toiminallisuus:");
    string valinta = Console.ReadLine();
    try
    {
        valintaNro = int.Parse(valinta);
    }
    catch (Exception ex)
    {
        continue;
    }
    switch (valintaNro)
    {
        case 0: Environment.Exit(0); break;
        case 1: NaytaVaraukset(); break;
        case 2: VaraaVuoro(); break;
        case 3: AnnaPalaute(); break;
    }

}
void NaytaVaraukset()
{
    var input = File.ReadAllLines("./Varaukset.txt");
    foreach (var v in input)
    {
        Console.WriteLine(v);

    }

}
void VaraaVuoro()
{
    Console.WriteLine("Anna vuorosi päivämäärä ja ajankohta (Esim. 8.10.2024 8.00-9.00):");
    string vuoro = Console.ReadLine();
    List<string> output = new List<string>();
    output.Add(vuoro);

    File.AppendAllLines("C:\\Users\\c165683\\source\\repos\\ConsoleApp1\\ConsoleApp1\\Varaukset.txt", output);



}
void AnnaPalaute()
{
    Console.WriteLine("Anna palautetta palvelusta:");
    Console.ReadLine();
    Console.WriteLine("Kiitos palautteestasi");
}

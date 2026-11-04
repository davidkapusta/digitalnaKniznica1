namespace DigitalnaKniznica;

class Program
{
    static void Main(string[] args)
    {
        kniha kniha1 = new kniha();
        kniha1.NazovKnihy = "Hobit";
        kniha1.MenoAutora = "J.R.R. Tolkien";
        kniha1.RokVydaniaKnihy = 1937;
        kniha1.Dostupnost = true;
        kniha kniha2 = new kniha();
        kniha2.NazovKnihy = "Pán Prsteňov: Spoločenstvo Prsteňa";
        kniha2.MenoAutora = "J.R.R. Tolkien";
        kniha2.RokVydaniaKnihy = 1954;
        kniha2.Dostupnost = true;
        kniha kniha3 = new kniha();
        kniha3.NazovKnihy = "Malý princ";
        kniha3.MenoAutora = "Antoine de Saint-Exupéry";
        kniha3.RokVydaniaKnihy = 1943;
        kniha3.Dostupnost = false;
        kniha kniha4 = new kniha();
        kniha4.NazovKnihy = "Pýcha a predsudok";
        kniha4.MenoAutora = "Jane Austen";
        kniha4.RokVydaniaKnihy = 1813;
        kniha4.Dostupnost = false;
        while (true)
        {
            Console.WriteLine("Zadaj prikaz (vyhladaj/pridaj): ");
            string prikaz = Console.ReadLine();
            Console.WriteLine();
            if (prikaz != "vyhladaj" && prikaz != "pridaj" && prikaz != "exit")
            {
                Console.WriteLine();
                Console.WriteLine("Zadaj prosim spravny prikaz");
            }
            else
            {
                if (prikaz == "vyhladaj")
                {
                    
                }

                if (prikaz == "pridaj")
                {
                    
                }

                if (prikaz == "exit")
                {
                    Environment.Exit(0);
                }
                Console.WriteLine();
            }
        }
    }
}

class kniha
{
    public string NazovKnihy;
    public string MenoAutora;
    public int RokVydaniaKnihy;
    public bool Dostupnost;
}

class kniznica
{
    public List<kniha> Zoznam = new List<kniha>();
    void pridaj()
    {
        Console.WriteLine("Zadaj názov knihy: ");
        string NazovKnihy = Console.ReadLine();
        Console.WriteLine("Zadaj meno autora: ");
        string MenoAutora = Console.ReadLine();
        Console.WriteLine("Zadaj rok vydania knihy: ");
        string rokVydania = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Zadaj prosim dostupnost knihy (dostupna/nedostupna): ");
        string DostupnostKnihy = Console.ReadLine();
        List<string> zoznam = new List<string>();
        zoznam.Add(NazovKnihy);
        zoznam.Add(MenoAutora);
        zoznam.Add(rokVydania);
        zoznam.Add(DostupnostKnihy);
    }
}    

    
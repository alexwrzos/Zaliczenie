public class HelloWorld
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int losowanaLiczba = random.Next(1,11);
        int wpisanaLiczba;
        int roznica;
        //Console.WriteLine("Wylosowana liczba: " + losowanaLiczba); //do testowania
        Console.WriteLine("Zagrajmy w Cieplo/Zimno!");
        Console.WriteLine("Masz 5 prob.");
        Console.WriteLine("Wpisz liczbe:");
        
        for (int i=0; i<5; i++)
        {
            while (int.TryParse(Console.ReadLine(), out wpisanaLiczba) == false || wpisanaLiczba <11 == false || wpisanaLiczba>0 == false)
            {
                Console.WriteLine("Nie wpisano liczby od 1 do 10. Sprobuj ponownie.");
            }
            //wpisanaLiczba = int.Parse(Console.ReadLine());
            if (wpisanaLiczba == losowanaLiczba)
            {
                Console.WriteLine("Zwyciestwo!");
                break;
            }
            else if ((roznica = Math.Abs(losowanaLiczba - wpisanaLiczba))<=2) //Math.ABS usuwa minusa
                Console.WriteLine("Cieplo!");
                else Console.WriteLine("Zimno!");
        }
        Console.WriteLine("Koniec! Wylosowana liczba to: " + losowanaLiczba);
    }
}
class Program
{
    int[] liczby = new int[10];
    public void DodajLiczbe(int index , int liczba)
    {
        liczby[index] = liczba;
    }
    public void WyswietlTablice()
    {
        Sortowanie();
        Console.Write("[ ");
        foreach (int i in liczby)
        {
            Console.Write(i);
        }
        Console.Write(" ]");
    }
    public void Sortowanie()
    {
        WyszukajMiminum();
    }
    private void WyszukajMiminum()
    {
        for (int i = 0; i < liczby.Length; i++)
        {
            int min = i;
            for (int j = i + 1; j < liczby.Length; j++)
            {
                if (liczby[i] > liczby[j])
                {
                    min = j;
                }
            }

            int temp = liczby[i];
            liczby[min] = liczby[i];
            liczby[i] = temp;

        }
    }
}
class Zadane
{

    public static void Main()
    {
        Program program = new Program();
        Console.WriteLine("Wpisz 10 liczb całkowitych");
        for (int i = 0; i < 10; i++) // Fixed the loop condition
        {
            int liczbaTable1;
            if (int.TryParse(Console.ReadLine(), out liczbaTable1)) // Use TryParse to handle null input
            {
                program.DodajLiczbe(i, liczbaTable1);
                Console.WriteLine("Dodano liczbę : " + liczbaTable1 + " na miejscu : " + i);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba. Spróbuj ponownie.");
                i--; // Decrement the counter to repeat the iteration
            }
        }
        program.WyswietlTablice();
        program.Sortowanie();
        program.WyswietlTablice();
    }

}

class Program
{
       static void Main(string[] args)
    {
        int[] tab = new int[100];

        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = Random.Shared.Next(1, 100);
        }
       bubleSort(tab);
    }

    static void bubleSort(int[] tab)
    {
        for (int i = 0; i < tab.Length - 1; i++)
        {
            for (int j = 0; j < tab.Length - i - 1; j++)
            {
                if (tab[j] > tab[j + 1])
                {
                    int temp = tab[j];
                    tab[j] = tab[j + 1];
                    tab[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Wylosowane liczby:");
        for (int j = 0; j < tab.Length; j++)
        {
            Console.WriteLine(tab[j]);
        }
    }

}
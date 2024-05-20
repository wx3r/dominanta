using System.Security.Cryptography.X509Certificates;

class Program 
{
    static void Main()
    {
        Console.WriteLine("Podaj rozmiar listy:");
        int wielkosc = int.Parse(Console.ReadLine());

        List<int> list = new List<int>();   
        Random random = new Random();
        for (int i = 0; i < wielkosc; i++)
        {
            list.Add(random.Next(1,101));
        }

        Console.WriteLine("Wygenerowana lista:");
        foreach(int number in list)
        {
            Console.WriteLine(number + " ");
        }
        Console.WriteLine();

        int dominanta = ZnajdzDominante(list, wielkosc);
        Console.WriteLine("Dominanta: "+ dominanta);
    }
    static int ZnajdzDominante(List<int> list, int wielkosc)
    {
        int maxLicz = 0;
        int dominanta = list[0];

        for (int i = 0; i< wielkosc;i++)
        {
            int count = 0;
            for (int j = 0; j < wielkosc;j++)
            {
                if (list[j] == list[i]) 
                {
                    count ++;
                }
            }
            if (count > maxLicz)
            {
                maxLicz = count;
                dominanta = list[i];
            }
        }
        return dominanta;
    }
}
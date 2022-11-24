int[] arr = new int[4];
for (int i = 0; i < 4; i++)
{
    Console.WriteLine("Zadejte {0}. hodnotu", i + 1);
    arr[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < 4; i++) Console.Write(arr[i]); Console.WriteLine();
for (int j = 0; j < 3; j++)
    if (arr[j] < arr[j + 1])
    {
        int pom = arr[j + 1];
        arr[j + 1] = arr[j];
        arr[j] = pom;
    }
Console.Write(arr[1]); //vypsání 1. hodnoty řady
Console.ReadLine();

// < sub > -spodní index
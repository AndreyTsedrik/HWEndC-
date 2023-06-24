Console.Write("Введите массив строк через пробел: ");
string[] FirstArray = Console.ReadLine().Split();
string[] SecondArray = new string[FirstArray.Length];
int j = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if (FirstArray[i].Length <= 3)
        {
            SecondArray[j] = FirstArray[i];
            j++;
        }
    }

string[] words = { "абр", "123", "хурма", "дом", "пенал", "игорь", "ААА", "ура", "yandex", "почка" };
string[] newArray = new string[words.Length];
void SecondArray(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            newArray[j] = array[i];
        j++;
    }
}
void ShowArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
SecondArray(words);
ShowArray(newArray);

//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символам

Console.Clear();

string[] oldarray = new string[5] { "Soft", "GeekBrains", "Yes", "24", "HardWork" };
string[] newarray = new string[oldarray.Length];

void NewShortArray(string[] oldarray, string[] newarray)
{
    int index = 0;
    for (int i = 0; i < oldarray.Length; i++)
    {
        if (oldarray[i].Length <= 3)
        {
            newarray[index] = oldarray[i];
            index++;
        }
    }

}

void PrintArray(string[] shortarray)
{
    for (int i = 0; i < shortarray.Length; i++)
    {
    Console.Write($"{shortarray[i]} ");
    }
    //Console.WriteLine();
}


NewShortArray(oldarray, newarray);
PrintArray(newarray);
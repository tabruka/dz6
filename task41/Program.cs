// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите несколько любых чисел: ");
int[] array = StringToNum(Console.ReadLine());
Console.Write("Вы ввели следующие числа: ");
PrintArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count = count + 1;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чисел, которые больше нуля: {count}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count = count + 1;
        }
    }

    int[] array = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = " ";

        while (input [i] != ' ')
        {
        if(i != input.Length - 1)
        {
            temp = temp + input [i].ToString();
            i = i  + 1;
        }
        else
        {
            temp = temp + input [i].ToString();
            break;
        }
        }
        array[index] = int.Parse(temp);
        index++;
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

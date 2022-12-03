// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3



Console.Write("Введите через запятую любое количество чисел: ");
int[] numbers = StringToNum(Console.ReadLine()!); //переводим строку в массив
//Console.WriteLine("Полученный массив:");
//Console.Write("["+ string.Join(", ", numbers)+ "]");//печатаем массив
//Console.WriteLine();
Console.WriteLine($"Количество чисел больше нуля равно: {SumNumbers(numbers)}");

//Получаем массив
int[] StringToNum(string input)
{
    //посчитаем количество чисел в строке (на 1 больше, чем запятых)
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }
    //создаем массив с учетом вычисленной длины count

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

//в полученном массиве посчитаем числа > 0, через следующую функцию:

int SumNumbers(int[] array)
{
  int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    {
        sum++;
    }
  }
return sum;
}






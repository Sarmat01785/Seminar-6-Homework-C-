//                               Задача 41:
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 4


int InputNum(string msg)
{
    Console.Write(msg);
    string value = Console.ReadLine();
    int resalt = Convert.ToInt32(value);
    return resalt;
}

int Greaterthanzero(int num)
{
    int index = 0;
    for (int i = 1; i <= num; i++)
    {
        int number = InputNum($"Введите число {i}: ");
        if (number > 0)
            index++;
    }
    return index;
}

int numbers = InputNum("Введите количество чисел: ");
int res = Greaterthanzero(numbers);
Console.WriteLine($"Пользователь ввел чисел болше нуля: {res}");

// Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.

// 11 -> 2, 3, 5, 7, 11

bool IsNumberSimple(int number)
    {
        for (int i = 2; i < number; i++)
            {  
                if (number % i == 0)
                    {
                        return false;
                    }
            }
        return true;
    }

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;
List<int> simpleNumbers = new List<int>();
while (i <= number)
    {
        bool simpleNumber = IsNumberSimple(i);
        if (simpleNumber) // if (simpleNumber == true)
            {
                simpleNumbers.Add(i);
            }
        i++;
    }

Console.WriteLine(String.Join(", ", simpleNumbers.ToArray()));
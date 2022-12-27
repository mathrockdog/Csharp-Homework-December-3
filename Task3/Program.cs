//Задача 23: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int[] Cubes(int number)
    {
        int[] cubes = new int[number];
        for (int i = 0; i < number; i++)
            {
                cubes[i] = Convert.ToInt32(Math.Pow(i + 1, 3));
            }
        return cubes;
    }

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int[] cubes = Cubes(number);
Console.WriteLine(String.Join(", ", cubes));
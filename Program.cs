bool IsWork = true;

while (IsWork)
{
    Console.WriteLine("Программа принимает на вход массив указанного размера и на выходе создаёт массив содержащий все элементы первого массива меньше 3х символов");
    Console.WriteLine();
    Console.WriteLine("Для начала работы введите 1");
    Console.WriteLine("Для завершения работы введите -1");

    if (int.TryParse(Console.ReadLine(), out int i))
    {
        switch (i)
        {
            case 1:
                {
                    Task_1();

                    void Task_1()
                    {
                        int ReadInt(string argument)
                        {
                            Console.Write($"{argument}");
                            int number;

                            while (!int.TryParse(Console.ReadLine(), out number))
                            {
                                Console.WriteLine("вы ввели не число");
                            }

                            return number;
                        }

                        string[] StartedArray(int size)
                        {
                            string[] newArray = new string[size];

                            for (int i = 0; i < newArray.GetLength(0); i++)
                            {
                                Console.Write("введите значение: ");
                                newArray[i] = Console.ReadLine();
                            }

                            return newArray;
                        }
                    }
                    break;
                }

            case -1: IsWork = false; break;
        }
    }
}
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
                        Console.WriteLine("Если хотите создать массив самостоятельно, введите 1");
                        Console.WriteLine("Если хотите использовать заготовленный массив, введите 2");

                        if (int.TryParse(Console.ReadLine(), out int j))
                        {
                            switch (j)
                            {
                                case 1:
                                    {
                                        Console.WriteLine();
                                        int size = ReadInt("Укажите размер массива (размер не может быть меньше 1): ");

                                        while (size <= 0)
                                        {
                                            size = ReadInt("Введите число больше 0: ");
                                        }

                                        Console.WriteLine();
                                        string[] firstArray = CreateNewArray(size);
                                        Console.WriteLine();
                                        Console.Write("Получился массив: ");
                                        Console.WriteLine(String.Join(", ", firstArray));
                                        Console.WriteLine();
                                        string[] secondArray = ConvertArray(firstArray);
                                        Console.Write("Преобразованный массив: ");
                                        Console.WriteLine(String.Join(", ", secondArray));
                                        Console.WriteLine();

                                        int ReadInt(string argument)
                                        {
                                            Console.Write($"{argument}");
                                            int number;

                                            while (!int.TryParse(Console.ReadLine(), out number))
                                            {
                                                Console.WriteLine("Вы ввели не число");
                                            }

                                            return number;
                                        }

                                        string[] CreateNewArray(int size)
                                        {
                                            string[] newArray = new string[size];

                                            for (int i = 0; i < newArray.GetLength(0); i++)
                                            {
                                                Console.Write("Введите значение: ");
                                                newArray[i] = Console.ReadLine();
                                            }

                                            return newArray;
                                        }

                                        string[] ConvertArray(string[] array)
                                        {
                                            int newArraySize = 0;

                                            for (int i = 0; i < array.GetLength(0); i++)
                                            {
                                                if (array[i].Length <= 3)
                                                {
                                                    newArraySize++;
                                                }
                                            }

                                            string[] newArray = new string[newArraySize];

                                            int j = 0;

                                            for (int i = 0; i < array.GetLength(0); i++)
                                            {
                                                if (array[i].Length <= 3)
                                                {
                                                    newArray[j] = array[i];
                                                    j++;
                                                }
                                            }

                                            return newArray;
                                        }

                                        break;
                                    }
                                case 2:
                                    {
                                        string[] array = new string[6]{"qwer", "123", ":-P", "-12", "12qw", "9842"};

                                        Console.WriteLine();
                                        Console.Write("Заготовленный массив: ");
                                        Console.WriteLine(String.Join(", ", array));
                                        Console.WriteLine();
                                        string[] secondArray = ConvertArray(array);
                                        Console.Write("Преобразованный массив: ");
                                        Console.WriteLine(String.Join(", ", secondArray));
                                        Console.WriteLine();

                                        string[] ConvertArray(string[] array)
                                        {
                                            int newArraySize = 0;

                                            for (int i = 0; i < array.GetLength(0); i++)
                                            {
                                                if (array[i].Length <= 3)
                                                {
                                                    newArraySize++;
                                                }
                                            }

                                            string[] newArray = new string[newArraySize];

                                            int j = 0;

                                            for (int i = 0; i < array.GetLength(0); i++)
                                            {
                                                if (array[i].Length <= 3)
                                                {
                                                    newArray[j] = array[i];
                                                    j++;
                                                }
                                            }

                                            return newArray;
                                        }

                                        break;
                                    }
                            }
                        }
                    }

                    break;
                }

            case -1: IsWork = false; break;
        }
    }
}
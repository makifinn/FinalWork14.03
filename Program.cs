﻿bool IsWork = true;

while(IsWork)
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
                    
                }
                break;
            }

            case -1: IsWork = false; break;
        }
    }
}
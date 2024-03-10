using System;

class Program
{
    static string[] FilterStrings(string[] arr)
    {
        int count = 0; // Счетчик для отслеживания индекса в результирующем массиве

        // Проходим по каждой строке в исходном массиве
        for (int i = 0; i < arr.Length; i++)
        {
            // Если длина строки меньше или равна 3, увеличиваем счетчик
            if (arr[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив с фактическим размером (без пустых элементов)
        string[] finalResult = new string[count];
        count = 0; // Сбрасываем счетчик

        // Заполняем новый массив отфильтрованными строками
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                finalResult[count] = arr[i];
                count++;
            }
        }

        return finalResult;
    }

    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int arraySize = Convert.ToInt32(Console.ReadLine());

        string[] inputArray = new string[arraySize];

        Console.WriteLine("Введите элементы массива:", arraySize);
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Элемент {0}: ", i + 1);
            inputArray[i] = Console.ReadLine();
        }

        string[] outputArray = FilterStrings(inputArray);

        
        for (int i = 0; i < outputArray.Length; i++)
        {
            Console.Write(outputArray[i]);
            if (i < outputArray.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine(); // Переход на новую строку
    }
}



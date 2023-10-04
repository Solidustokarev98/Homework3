
Console.WriteLine("Метод для фильтрации массива на основании переданных параметров");
int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
int[] filterArray = { 6, 88, 7 };

int[] resultArray = FilterArray(originalArray, filterArray);

Console.WriteLine("Результат фильтрации:");
foreach (int num in resultArray)
{
    Console.Write(num + " ");
}

static int[] FilterArray(int[] originalArray, int[] filterArray)
{
    int[] resultArray = new int[originalArray.Length];
    int resultIndex = 0;

    // Проходим по каждому элементу оригинального массива
    foreach (int num in originalArray)
    {
        // Проверяем, есть ли этот элемент в массиве для фильтрации
        bool isInFilterArray = false;
        foreach (int filterNum in filterArray)
        {
            if (num == filterNum)
            {
                isInFilterArray = true;
                break;
            }
        }

        // Если элемент не найден в массиве для фильтрации, добавляем его в результат
        if (!isInFilterArray)
        {
            resultArray[resultIndex] = num;
            resultIndex++;
        }
    }

    // Создаем новый массив размером с количеством найденных элементов
    int[] finalResult = new int[resultIndex];
    Array.Copy(resultArray, finalResult, resultIndex);

    return finalResult;
}
// Быстрая сортировка O(n * log2(n))
// Напишите программу, которая сложит натуральные числа a и b без прямого сложения
/*
Структура программного кода:
Импорт всех модулей/библиотек
Создание объектов и их методов
Функии и процедуры
Основной программный код
*/
// int sumNumbers(int a, int b){
//     if (b == 0)
//         return a;
//     return sumNumbers(a + 1, b - 1);
// }
// /* f = sumNumbers
// f(5, 3) -> f(6, 2) -> f(7, 1) -> f(8, 0) -> 8
// */

// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{n} + {m} = {sumNumbers(n, m)}");

// Найти n-ое число Фибоначчи
// f(n) = f(n - 1) + f(n - 2)
// 0 1 1 2 3 5 8 13 21 34 55
// 0 1 2 3 4 5 6 7  8  9


// int fib(int n){
//     if (n == 0 || n == 1)
//         return n;
//     return fib(n - 1) + fib(n - 2);
// }
// /*
// O(2^n)
// n = 5
// fib(5) -> fib(4) + fib(3) = 3 + 2 = 5
//           |             |
//           |             fib(2) + fib(1) = 1
//           |                |
//   2=fib(3) + fib(2)  fib(1) + fib(0)
//      |           |
// fib(2) + fib(1)  fib(1) + fib(0)  
// |           1       1       0
// fib(1) + fib(0) = 1 + 0
// |           | 
// 1           0
// */
// Console.Clear();
// Console.Write("Введите номер: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(fib(n));
// int a0 = 0, a1 = 1, aNext;
// // O(n)    O(10)
// // O(2^n)  O(1024)
// for (int i = 0; i < n; i++){ // выполнится n раз
//     Console.Write($"{a1} ");
//     aNext = a0 + a1;
//     a0 = a1;
//     a1 = aNext;
// }
/*
a0 = 0
a1 = 1
aNext = a0 + a1 = 0 + 1 = 1
a0 = a1 = 1
a1 = aNext = 1
aNext = a0 + a1 = 1 + 1 = 2
a0 = a1 = 1
a1 = aNext = 2
....
*/

/* Алгоритм Быстрой Сортировки
array = [7, 4, 1, 3, 5, 2, 8, 6]
pivot = array[0]
[4, 1, 3, 5, 2, 6] + [7] + [8] = [] + [1] + [2] + [3] + [] + [4] + [] + [5] + [6] + [7] + [8]

array = [4, 1, 3, 5, 2, 6]
pivot = array[0] = 4
[1, 3, 2] + [4] + [5, 6]

array = [1, 3, 2]
pivot = 1
[] + [1] + [3, 2]


array = [3, 2]
pivot = 3
[2] + [3] + []


array = [5, 6]
pivot = 5
[] + [5] + [6]
*/
int[] Concat(int[] a, int[] b, int[] c)
{
    int[] result = new int[a.Length + b.Length + c.Length];
    for (int i = 0; i < a.Length; i++)
    {
        result[i] = a[i];
    }
    for (int i = a.Length; i < a.Length + b.Length; i++)
    {
        result[i] = b[i - a.Length];
    }
    for (int i = a.Length + b.Length; i < result.Length; i++)
    {
        result[i] = c[i - (a.Length + b.Length)];
    }
    return result;
}

int[] quickSort(int[] array)
{
    if (array.Length < 2)
    {
        return array;
    }
    else
    {
        int pivot = array[0];
        int count = 0;
        foreach (int element in array)
        {
            if (element < pivot)
                count++;
        }
        int[] less = new int[count];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < pivot)
            {
                less[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach (int element in array)
        {
            if (element > pivot)
                count++;
        }
        int[] greater = new int[count];
        j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > pivot)
            {
                greater[j] = array[i];
                j++;
            }
        }
        count = 0;
        foreach (int element in array)
        {
            if (element == pivot)
                count++;
        }
        int[] pivotArray = new int[count];
        for (int i = 0; i < count; i++)
        {
            pivotArray[i] = pivot;
        }
        int[] result = Concat(quickSort(less), pivotArray, quickSort(greater));
        return result;
    }
}


Console.Clear();
int[] array = { 7, 4, 1, 3, 5, 2, 8, 6 };
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Отсортированный массив: [{string.Join(", ", quickSort(array))}]");



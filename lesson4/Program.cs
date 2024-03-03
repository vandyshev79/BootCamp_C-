// Пузырьковая сортировка.

//int n = 20;
//int max = 100;


using System.Diagnostics;

bool Check(int[] array)                        // Делаем проверку: Если массив правильно отсортирован, то пишет true
{                                              // Unit-test
    int size = array.Length;

    for (int i = 0; i < size - 1; i++)
    { 
        if (array[i] > array[i + 1])
        {
            return false;
        }
    }
    return true;
}

bool show = !true;




Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int max = 100;
int[] array = new int[n];
for (int i = 0; i < n; i++) array[i] = Random.Shared.Next(max);    // Создание массива.
// for (int i = 0; i < n; i++) array[i] = n -1;
if (show) Console.WriteLine($"Неотсортированный массив(array): [{String.Join(',', array)}]");      // Вывод на экран начального массива.
Console.WriteLine();

int[] array1 = new int[n];
int[] array2 = new int[n];
int[] array3 = new int[n];
int[] array4 = new int[n];

Array.Copy(array, array1, n);
Array.Copy(array, array2, n);
Array.Copy(array, array3, n);
Array.Copy(array, array4, n);

//if (show) Console.WriteLine($"array1: [{String.Join(',', array1)}]");

Stopwatch sw = new Stopwatch();
sw.Start();

for (int k = 0; k < n - 1; k++)                          // Цикл для переборки.(Алгоритм сортировки) 1 вид
{
    for (int i = 0; i < n - 1 - k; i++)
    {
        if (array1[i] > array1[i + 1])
        {
            int temp = array1[i];
            array1[i] = array1[i + 1];
            array1[i + 1] = temp;
        }
    }
}

sw.Stop();
if (show) Console.WriteLine($"array1: [{String.Join(',', array1)}]");
System.Console.WriteLine($"array1 - {Check(array1)} {sw.ElapsedMilliseconds}ms");
//if (show) Console.WriteLine($"array2: [{String.Join(',', array2)}]");
//Console.ReadLine();

sw.Reset();
sw.Start ();


for (int k = 0; k < n - 1; k++)                          // Цикл для переборки.(Алгоритм сортировки) 2 вид
{
    for (int i = 0; i < n - 1; i++)
    {
        if (array2[i] > array2[i + 1])
        {
            int temp = array2[i];
            array2[i] = array2[i + 1];
            array2[i + 1] = temp;
        }
    }
}
sw.Stop();
if (show) Console.WriteLine($"array2: [{String.Join(',', array2)}]");      // Вывод на экран отсортированного массива.
System.Console.WriteLine($"array2 - {Check(array2)} {sw.ElapsedMilliseconds}ms");

sw.Reset();
sw.Start();


for (int k = 0; k < n; k++)                          // Цикл для переборки.(Алгоритм сортировки) 3 вид
{
    for (int i = 0; i < n - 1; i++)
    {
        if (array3[i] > array3[i + 1])
        {
            int temp = array3[i];
            array3[i] = array3[i + 1];
            array3[i + 1] = temp;
        }
    }
}
sw.Stop();

if (show) Console.WriteLine($"array3: [{String.Join(',', array3)}]");      // Вывод на экран отсортированного массива.
System.Console.WriteLine($"array3 - {Check(array3)} {sw.ElapsedMilliseconds}ms");

sw.Reset();
sw.Start();


for (int k = 0; k < n; k++)                          // Цикл для переборки.(Алгоритм сортировки) 4 вид
{
    for (int i = 0; i < n - 1 - k; i++)
    {
        if (array4[i] > array4[i + 1])
        {
            int temp = array4[i];
            array4[i] = array4[i + 1];
            array4[i + 1] = temp;
        }
    }
}
sw.Stop();

if (show) Console.WriteLine($"array4: [{String.Join(',', array4)}]");      // Вывод на экран отсортированного массива.
System.Console.WriteLine($"array4 - {Check(array4)} {sw.ElapsedMilliseconds}ms");



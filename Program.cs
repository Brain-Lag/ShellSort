using System;

//static bool ArrayContains(int[] numbers, int number)
//{
//    foreach (var num in numbers) if (number == num) return true;
//    return false;
//}
//static int[] UniqueRandomArray(int min, int max, int length, Random? random = null)
//{
//    if (min >= max) throw new ArgumentException("Не верно задан диапазон: min >= max");
//    if ((max - min) < length) throw new ArgumentException("Диапазон не позволяет создать уникальный список: (max - min) <= length");

//    random = random ?? new Random(DateTime.Now.Millisecond);
//    var result = new int[length];
//    var zeroFirst = true;
//    for (var i = 0; i < length; i++)
//    {
//        var res = 0;
//        do
//        {
//            res = random.Next(min, max);
//            if (res == 0)
//            {
//                if (zeroFirst)
//                {
//                    zeroFirst = false;
//                    break;
//                }
//                continue;
//            }
//        } while (ArrayContains(result, res));
//        result[i] = res;
//    }
//    return result;
//}

//static string ArrayToString(int[] numbers, bool show = true)
//{
//    StringBuilder sb = new StringBuilder();
//    foreach (var item in numbers) sb.Append(item).Append(' ');
//    var result = sb.ToString().TrimEnd(' ');
//    if (show) Console.WriteLine(result);
//    return result;
//}

class Array
{
    static void Main()
    {
        Console.WriteLine("Введите количество элементов массива");
        int N = int.Parse(Console.ReadLine());
        int[] Arr = new int[N];
        Random rnd = new Random();
        Console.Write("Исходный массив: ");
        for (int i = 0; i < Arr.Length; i++)
        {
            Arr[i] = rnd.Next(-200, 200);
            Console.Write(Arr[i] + ", ");
        }
        Console.WriteLine();
        Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", ShellSort(Arr)));
    }

    static int[] ShellSort(int[] Arr)
    {
        int i = Arr.Length / 2;
        int j;
        while (i >= 1)
        {
            for ( j = i; j < Arr.Length; j++)
            {
                int k = j;
                while ((k >= i) && (Arr[k - i] > Arr[k]))
                {
                    Swap(ref Arr[k], ref Arr[k - 1]);
                    k -= i;
                }
            }
            i /= 2;
        }

        return Arr;
    }
    static void Swap(ref int a, ref int b)
    {
        var t = a;
        a = b;
        b = t;
    }
}
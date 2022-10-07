using Hw1.Searching;
using Hw1.Sorting;
using Hw1.Utils;
using System.Collections;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace Program;

class Programm
{
    /*
     * Выводы:
     * Сортировка пузырьком быстрее остальных
     * Простой поиск от бинарного не далеко ушел по производительности
     * Класс Timing работает через раз
     * Хеш таблицы быстрее, но с дженериками поиск не такой быстрый
     */
    public static void fillArray(ref int[] arr)
    {
        Random randNum = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = randNum.Next(0, 100);
        }
    }
    public static void fillHashTable(ref Hashtable arr)
    {
        Random randNum = new Random();
        for (int i = 0; i < arr.Count; i++)
        {
            arr.Add(i, randNum.Next(0, 100));
            // а что я еще могу использовать в качестве ключа?)
        }
    }
    public static void Main(string[] args)
    {
        int[] Arr = new int[10000];
        Hashtable ArrHt = new Hashtable();
        fillArray(ref Arr);
        fillHashTable(ref ArrHt);

        Timing t = new Timing();
        Stopwatch sw = new Stopwatch();
        TimeSpan timeTaken;


        /*
         * сортировка пузырьком
         */
        ExchangeSorting exchangeSorting = new ExchangeSorting();

        sw.Start();
        exchangeSorting.BubleSort(Arr); // сам метод сортировки
        sw.Stop();
        timeTaken = sw.Elapsed;

        Console.WriteLine("Время выполнения сортировки пузырьком (StopWatch): " + timeTaken.ToString(@"m\:ss\.fff"));

        t = new Timing();
        t.StartTime();
        exchangeSorting.BubleSort(Arr); // сам метод сортировки
        t.StopTime();
        Console.WriteLine($"Время выполнения сортировки пузырьком (Timing): {t.Result().ToString()}");

        /*
         * сортировка простыми включениями 
         */

        //SimpleInclusionsSorting inclusionsSorting = new SimpleInclusionsSorting();

        //sw.Start();
        //inclusionsSorting.SortInsertion(Arr); // сам метод сортировки
        //sw.Stop();
        //timeTaken = sw.Elapsed;

        //Console.WriteLine("Время выполнения сортировки простыми включениями (StopWatch): " + timeTaken.ToString(@"m\:ss\.fff"));

        //t = new Timing();
        //t.StartTime();
        //inclusionsSorting.SortInsertion(Arr); // сам метод сортировки
        //t.StopTime();
        //Console.WriteLine($"Время выполнения сортировка простыми включениями (Timing): {t.Result().ToString()}");

        /*
         * сортировка простым выбором 
         */
        SimpleSelectionSorting simpleSelectionSorting = new SimpleSelectionSorting();

        sw.Start();
        simpleSelectionSorting.SortSelection(Arr); // сам метод сортировки
        sw.Stop();
        timeTaken = sw.Elapsed;

        Console.WriteLine("Время выполнения сортировки простым выбором (StopWatch): " + timeTaken.ToString(@"m\:ss\.fff"));

        t = new Timing();
        t.StartTime();
        simpleSelectionSorting.SortSelection(Arr); // сам метод сортировки
        t.StopTime();
        Console.WriteLine($"Время выполнения сортировки простым выбором (Timing): {t.Result().ToString()}");

        /*
         * простой поиск 
         */
        SimpleSearch simpleSearch = new SimpleSearch();

        sw.Start();
        simpleSearch.Search(Arr, 100); // сам метод поиска
        sw.Stop();
        timeTaken = sw.Elapsed;

        Console.WriteLine("Время выполнения простого поиска(StopWatch): " + timeTaken.ToString(@"m\:ss\.fff"));

        t = new Timing();
        t.StartTime();
        simpleSearch.Search(Arr, 100); // сам метод поиска
        t.StopTime();
        Console.WriteLine($"Время выполнения простого поиска(Timing): {t.Result().ToString()}");

        /*
         * бинарный поиск 
         */
        SearchBinary searchBinary = new SearchBinary();

        sw.Start();
        searchBinary.Search(Arr, 100); // сам метод поиска
        sw.Stop();
        timeTaken = sw.Elapsed;

        Console.WriteLine("Время выполнения бинарного поиска(StopWatch): " + timeTaken.ToString(@"m\:ss\.fff"));

        t = new Timing();
        t.StartTime();
        searchBinary.Search(Arr, 100); // сам метод поиска
        t.StopTime();
        Console.WriteLine($"Время выполнения бинарного поиска(Timing): {t.Result().ToString()}");

        /*
         * поиск по хэштаблице
         */

        sw.Start();
        ArrHt.Values.OfType<int>().Where(s => s == 100);
        sw.Stop();
        timeTaken = sw.Elapsed;

        Console.WriteLine("Время выполнения простого поиска по хэш таблице(StopWatch): " + timeTaken.ToString(@"m\:ss\.fff"));

        t = new Timing();
        t.StartTime();
        ArrHt.Values.OfType<int>().Where(s => s == 100);
        t.StopTime();
        Console.WriteLine($"Время выполнения простого поиска по хэш таблице (Timing): {t.Result().ToString()}");

    }
}

using DataAccess;
using DataAccess.Abstract.ReadAndWrite;
using DataAccess.Concrete.Reader;
using SortMethods;
using SortMethods.Concrete;

namespace Business;

public class SortingService
{
    readonly IReader _jsonReader;
    readonly SortingManager _sortingManager;


    public SortingService(IReader jsonReader, SortingManager sortingManager)
    {
        _jsonReader = jsonReader;
        _sortingManager = sortingManager;
    }

    public void SortAndPrintData(string pattern, string size, string outputChoice)
    {
        var jsonReader = GetDataReader(size);
        var sortingManager = GetSortingManager(pattern);

        var readedData = jsonReader.Read<long>();

        var sortedData = sortingManager.Sort(readedData);
        var unsortedData = new List<long>(readedData);


        PrintData(unsortedData, sortedData, outputChoice);
    }

    void PrintData(IList<long> unsortedData, IList<long> sortedData, string outputChoice)
    {
        if (outputChoice == "1")
        {
            for (var i = 0; i < unsortedData.Count; i++)
                Console.WriteLine($"Unsorted : {unsortedData[i]}     Sorted : {sortedData[i]}");
        }
        else if (outputChoice == "2")
        {
            // Hiçbir şey yazdırmayacak
        }
        else
        {
            Console.WriteLine("Invalid output choice");
        }
    }

    IReader GetDataReader(string size)
    {
        IReader reader;

        switch (size)
        {
            case "1":
                reader = new JsonReader(new Paths()._1k);
                break;
            case "2":
                reader = new JsonReader(new Paths()._10k);
                break;
            case "3":
                reader = new JsonReader(new Paths()._100k);
                break;
            case "4":
                reader = new JsonReader(new Paths()._1m);
                break;
            default:
                Console.WriteLine("Invalid size");
                return null;
        }

        return reader;
    }

    SortingManager GetSortingManager(string pattern)
    {
        var sortingManager = new SortingManager();
        ISortStrategy strategy = null;


        switch (pattern)
        {
            case "1":
                strategy = new BubbleSort();
                break;
            case "2":
                strategy = new HeapSort();
                break;
            case "3":
                strategy = new MergeSort();
                break;
            case "4":
                strategy = new QuickSort();
                break;
            case "5":
                strategy = new SelectionSort();
                break;
            default:
                Console.WriteLine("Invalid Pattern");
                return null;
        }

        sortingManager.SetSortStrategy(strategy);
        return sortingManager;
    }
}
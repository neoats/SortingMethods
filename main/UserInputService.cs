namespace Business;

public class UserInputService
{
    public string GetPatternChoice()
    {
        Console.Write("Choose Pattern (1: BubbleSort, 2: HeapSort, 3: MergeSort, 4: QuickSort, 5: SelectionSort): ");
        return Convert.ToString(Console.ReadLine());
    }

    public string GetDataSizeChoice()
    {
        Console.Write("Select Data Size (1: 1K, 2: 10K, 3: 100K, 4: 1M): ");
        return Convert.ToString(Console.ReadLine());
    }

    public string GetOutputChoice()
    {
        Console.Write("Choose output (1: Print both, 2: Print nothing): ");
        return Convert.ToString(Console.ReadLine());
    }
}
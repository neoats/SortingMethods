namespace SortMethods.Concrete;

public class QuickSort : ISortStrategy
{
    public IList<T> Sort<T>(IList<T> list) where T : IComparable<T>
    {
        Sort(list, 0, list.Count - 1);
        return list;
    }

    void Sort<T>(IList<T> list, int low, int high) where T : IComparable<T>
    {
        if (low < high)
        {
            var pivotIndex = Partition(list, low, high);
            Sort(list, low, pivotIndex - 1);
            Sort(list, pivotIndex + 1, high);
        }
    }

    void Swap<T>(IList<T> list, int i, int j)
    {
        var temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }

    public int Partition<T>(IList<T> list, int low, int high) where T : IComparable<T>
    {
        var pivot = list[high];
        var i = low - 1;

        for (var j = low; j < high; j++)
            if (list[j].CompareTo(pivot) < 0)
            {
                i++;
                Swap(list, i, j);
            }

        Swap(list, i + 1, high);
        return i + 1;
    }
}
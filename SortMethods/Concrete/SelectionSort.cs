namespace SortMethods.Concrete;

public class SelectionSort : ISortStrategy
{
    public IList<T> Sort<T>(IList<T> list) where T : IComparable<T>
    {
        var n = list.Count;
        for (var i = 0; i < n - 1; i++)
        {
            var minIndex = i;
            for (var j = i + 1; j < n; j++)
                if (list[j].CompareTo(list[minIndex]) < 0)
                    minIndex = j;
            if (minIndex != i) Swap(list, i, minIndex);
        }

        return list;
    }

    void Swap<T>(IList<T> list, int i, int j)
    {
        var temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
}
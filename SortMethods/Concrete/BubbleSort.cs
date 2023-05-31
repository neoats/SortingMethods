namespace SortMethods.Concrete;

public class BubbleSort : ISortStrategy
{
    public IList<T> Sort<T>(IList<T> list) where T : IComparable<T>
    {
        var n = list.Count;
        bool swapped;

        do
        {
            swapped = false;

            for (var i = 0; i < n - 1; i++)
                if (list[i].CompareTo(list[i + 1]) > 0)
                {
                    Swap(list, i, i + 1);
                    swapped = true;
                }

            n--;
        } while (swapped);

        return list;
    }

    void Swap<T>(IList<T> list, int i, int j)
    {
        var temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
}
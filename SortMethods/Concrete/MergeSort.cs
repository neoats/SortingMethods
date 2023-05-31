namespace SortMethods.Concrete;

public class MergeSort : ISortStrategy
{
    public IList<T> Sort<T>(IList<T> list) where T : IComparable<T>
    {
        if (list.Count <= 1)
            return list;

        var middle = list.Count / 2;

        IList<T> left = new List<T>();
        for (var i = 0; i < middle; i++)
            left.Add(list[i]);

        IList<T> right = new List<T>();
        for (var i = middle; i < list.Count; i++)
            right.Add(list[i]);

        left = Sort(left);
        right = Sort(right);

        return Merge(left, right);
    }

    IList<T> Merge<T>(IList<T> left, IList<T> right)
    {
        IList<T> result = new List<T>();

        var leftIndex = 0;
        var rightIndex = 0;

        while (leftIndex < left.Count && rightIndex < right.Count)
            if (Comparer<T>.Default.Compare(left[leftIndex], right[rightIndex]) <= 0)
            {
                result.Add(left[leftIndex]);
                leftIndex++;
            }
            else
            {
                result.Add(right[rightIndex]);
                rightIndex++;
            }

        while (leftIndex < left.Count)
        {
            result.Add(left[leftIndex]);
            leftIndex++;
        }

        while (rightIndex < right.Count)
        {
            result.Add(right[rightIndex]);
            rightIndex++;
        }

        return result;
    }
}
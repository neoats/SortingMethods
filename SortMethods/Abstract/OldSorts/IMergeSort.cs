namespace SortMethods.Abstract;

public interface IMergeSort
{
    IList<T> Sort<T>(IList<T> list) where T : IComparable<T>;
}
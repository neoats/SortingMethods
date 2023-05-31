namespace SortMethods.Abstract;

public interface IHeapSort
{
    IList<T> Sort<T>(IList<T> list) where T : IComparable<T>;
}
namespace SortMethods.Abstract;

public interface IQuickSort
{
    IList<T> Sort<T>(IList<T> list) where T : IComparable<T>;
}
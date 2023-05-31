namespace SortMethods.Abstract.OldSorts;

public interface IBubbleSort
{
    IList<T> Sort<T>(IList<T> list) where T : IComparable<T>;
}
namespace SortMethods.Concrete;

public interface ISortStrategy
{
    IList<T> Sort<T>(IList<T> list) where T : IComparable<T>;
}
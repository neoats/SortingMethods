namespace SortMethods.Concrete;

public interface ISelectionSort
{
    IList<T> Sort<T>(IList<T> list) where T : IComparable<T>;
}
using SortMethods.Concrete;

namespace SortMethods;

public class SortingManager
{
    ISortStrategy _sortStrategy;

    public void SetSortStrategy(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public IList<T> Sort<T>(IList<T> list) where T : IComparable<T>
    {
        return _sortStrategy?.Sort(list);
    }
}
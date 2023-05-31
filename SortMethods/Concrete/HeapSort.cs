namespace SortMethods.Concrete;

public class HeapSort : ISortStrategy
{
    public IList<T> Sort<T>(IList<T> list) where T : IComparable<T>
    {
        BuildMaxHeap(list);

        var heapSize = list.Count;
        for (var i = list.Count - 1; i >= 1; i--)
        {
            Swap(list, 0, i);
            heapSize--;
            MaxHeapify(list, 0, heapSize);
        }

        return list;
    }

    void BuildMaxHeap<T>(IList<T> list) where T : IComparable<T>
    {
        var heapSize = list.Count;
        for (var i = heapSize / 2 - 1; i >= 0; i--) MaxHeapify(list, i, heapSize);
    }

    void MaxHeapify<T>(IList<T> list, int index, int heapSize) where T : IComparable<T>
    {
        var leftChild = index * 2 + 1;
        var rightChild = index * 2 + 2;
        var largest = index;

        if (leftChild < heapSize && list[leftChild].CompareTo(list[largest]) > 0) largest = leftChild;

        if (rightChild < heapSize && list[rightChild].CompareTo(list[largest]) > 0) largest = rightChild;

        if (largest != index)
        {
            Swap(list, index, largest);
            MaxHeapify(list, largest, heapSize);
        }
    }

    void Swap<T>(IList<T> list, int i, int j)
    {
        var temp = list[i];
        list[i] = list[j];
        list[j] = temp;
    }
}
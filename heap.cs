using System;
using System.Collections.Generic;

class PriorityQueue<T>
{
    private List<Tuple<T, int>> heap;
    
    public int Count { get { return heap.Count; } }
    public bool IsEmpty { get { return heap.Count == 0; } }

    public PriorityQueue()
    {
        heap = new List<Tuple<T, int>>();
    }

    public void Enqueue(T item, int priority)
    {
        heap.Add(new Tuple<T, int>(item, priority));
        int childIndex = heap.Count - 1;
        while (childIndex > 0)
        {
            int parentIndex = (childIndex - 1) / 2;
            if (heap[childIndex].Item2 >= heap[parentIndex].Item2)
                break;
            Swap(childIndex, parentIndex);
            childIndex = parentIndex;
        }
    }

    public T Dequeue()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Priority queue is empty.");
        
        int lastIndex = heap.Count - 1;
        T frontItem = heap[0].Item1;
        heap[0] = heap[lastIndex];
        heap.RemoveAt(lastIndex);
        lastIndex--;

        int parentIndex = 0;
        while (true)
        {
            int childIndex = parentIndex * 2 + 1;
            if (childIndex > lastIndex)
                break;
            int rightChildIndex = childIndex + 1;
            if (rightChildIndex <= lastIndex && heap[rightChildIndex].Item2 < heap[childIndex].Item2)
                childIndex = rightChildIndex;
            if (heap[parentIndex].Item2 <= heap[childIndex].Item2)
                break;
            Swap(parentIndex, childIndex);
            parentIndex = childIndex;
        }

        return frontItem;
    }

    private void Swap(int index1, int index2)
    {
        Tuple<T, int> temp = heap[index1];
        heap[index1] = heap[index2];
        heap[index2] = temp;
    }
}
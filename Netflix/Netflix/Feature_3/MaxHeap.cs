namespace Netflix.Feature_3
{
    public class MaxHeap
    {
        List<int> heap;
        public int HeapSize
        {
            get
            {
                return heap.Count - 1;
            }
        }
        public MaxHeap(int size)
        {
            heap = new(size);
            heap.Add(0);
        }
        public MaxHeap()
        {
            heap = new();
            heap.Add(0);
        }

        // O(1)
        public int Peek()
        {
            if (HeapSize == 0)
                throw new Exception("The heap is EMPTY!");

            return heap[1];
        }

        public void Push(int number)
        {
            heap.Add(number);

            int parentIndex = (HeapSize) / 2;
            int currentIndex = HeapSize;

            while (parentIndex != 0)
            {
                if (heap[currentIndex] > heap[parentIndex])
                    swap(currentIndex, parentIndex);
                else
                    break;

                currentIndex = parentIndex;
                parentIndex = currentIndex / 2;
            }

        }
        public int Pop()
        {
            if (HeapSize == 0)
                throw new Exception("The heap is EMPTY!");


            int peak = Peek();
            int parentIndex = 1;
            int largestChildIndex;

            heap[1] = heap[HeapSize];
            heap.RemoveAt(HeapSize);

            while (parentIndex * 2 <= HeapSize)
            {
                if (parentIndex * 2 + 1 <= HeapSize && heap[parentIndex * 2] < heap[parentIndex * 2 + 1])
                {
                    largestChildIndex = parentIndex * 2 + 1;
                }
                else
                {
                    largestChildIndex = parentIndex * 2;
                }

                if (heap[parentIndex] < heap[largestChildIndex])
                {
                    swap(parentIndex, largestChildIndex);
                    parentIndex = largestChildIndex;
                }
                else
                {
                    break;
                }
            }

            return peak;
        }

        public void show()
        {
            foreach (var item in heap.Skip(1))
            {
                Console.Write($"{item} ");
            }
        }
        private void swap(int index1, int index2)
        {
            int temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }

    }
}

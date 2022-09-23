namespace Netflix.Feature_3
{
    public static class Feature3
    {
        static MaxHeap maxHeap;
        static MinHeap minHeap;

        static Feature3()
        {
            maxHeap = new();
            minHeap = new();
        }
        public static void addAge(int age)
        {
            if (maxHeap.HeapSize == 0 || age < maxHeap.Peek())
            {
                maxHeap.Push(age);
            }
            else
            {
                minHeap.Push(age);
            }

            if (maxHeap.HeapSize > minHeap.HeapSize + 1)
            {
                minHeap.Push(maxHeap.Pop());
            }
            else if (minHeap.HeapSize > maxHeap.HeapSize)
            {
                maxHeap.Push(minHeap.Pop());
            }
        }

        public static double getMedianOfAges()
        {
            if (maxHeap.HeapSize > minHeap.HeapSize)
                return maxHeap.Peek();

            else
                return (maxHeap.Peek() + minHeap.Peek()) / 2.0;

        }

    }
}

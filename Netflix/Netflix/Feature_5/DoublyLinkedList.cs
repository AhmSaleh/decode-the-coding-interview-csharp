namespace Netflix.Feature_5
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Size { get; set; }

        public void Remove(Node node)
        {

            if (node.Next == null)
            {
                Head = null;
            }
            else
            {
                if (node == Tail)
                {
                    Tail = node.Prev;
                }

                if (node != Head)
                {
                    node.Prev.Next = null;
                }

                node.Prev = null;
            }

            Size--;
        }
        public Node Add(int number)
        {
            if (Head == null)
            {
                Head = Tail = new Node(number);
            }
            else
            {
                Tail.Next = new Node(number);
                Tail.Next.Prev = Tail;
                Tail = Tail.Next;
            }
            Size++;
            return Tail;
        }

    }
}

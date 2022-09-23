namespace Netflix.Feature_5
{
    public class Node
    {
        public int Number { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(int number)
        {
            Number = number;
        }
    }
}

using Netflix.Feature_3;

namespace Netflix
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Feature 1 Run
            #region MyRegion
            //var titles = new List<string> { "duel", "dule", "speed", "spede", "deul", "cars" };
            //var titlesDic = Feautre1.getAnagramDict(titles);

            //foreach (var kvp in titlesDic)
            //{
            //    foreach (var title in kvp.Value)
            //    {
            //        Console.Write($"{title} ");
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            // Feature 2
            #region Feature 2
            //ListNode list1 = new(4);
            //list1.next = new(7);

            //ListNode list2 = new(1);
            //list2.next = new(9);


            //ListNode list3 = new(0);
            //list3.next = new(6);

            //ListNode result = Feature2.mergeKSortedLinkedList(new List<ListNode>() { list1, list2, list3 });

            //while (result != null)
            //{
            //    Console.WriteLine(result.val);
            //    result = result.next;
            //} 
            #endregion

            // Feature 2
            #region Feature 3


            #endregion



            //MinHeap heap = new();

            //heap.Push(10);
            //heap.Push(10);
            //heap.Push(2);
            //heap.Push(20);
            //heap.Push(1);


            //heap.show();

            Feature3.addAge(1);
            Feature3.addAge(7);
            Feature3.addAge(8);
            Feature3.addAge(7);
            Feature3.addAge(2);
            Feature3.addAge(10);

            Console.WriteLine(Feature3.getMedianOfAges());

        }


        //static addAge(int age) { 

        //}





    }
}
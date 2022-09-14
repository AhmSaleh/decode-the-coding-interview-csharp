namespace Netflix.Feature_2
{
    public static class Feature2
    {
        public static ListNode merge2SortedLinkedList(ListNode list1, ListNode list2)
        {

            ListNode dummy = new(-1);
            ListNode prev = dummy;

            while (list1 != null & list2 != null)
            {
                if (list1?.val < list2?.val)
                {
                    prev.next = list1;
                    list1 = list1.next;
                }
                else if (list1?.val > list2?.val)
                {
                    prev.next = list2;
                    list2 = list2.next;
                }
                else
                {
                    prev.next = list1;
                    list1 = list1.next;
                    list2 = list2.next;
                }

                prev = prev.next;
            }

            if (list1 == null)
                prev.next = list2;
            else
                prev.next = list1;

            return dummy.next;
        }
        public static ListNode mergeKSortedLinkedList(List<ListNode> lists)
        {
            ListNode list = null;

            if (lists.Count != 0)
                list = lists[0];

            for (int i = 1; i < lists.Count; i++)
            {
                list = merge2SortedLinkedList(list, lists[i]);
            }

            return list;
        }


    }
}

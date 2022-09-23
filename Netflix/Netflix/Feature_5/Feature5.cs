namespace Netflix.Feature_5
{
    public static class Feature5
    {
        static DoublyLinkedList list;
        static Dictionary<int, Node> IDsNodeMapperDic;

        static Feature5()
        {
            list = new();
            IDsNodeMapperDic = new();
        }

        public static void Visit(int id)
        {

            if (IDsNodeMapperDic.ContainsKey(id))
            {
                list.Remove(IDsNodeMapperDic[id]);
            }
            else if (IDsNodeMapperDic.Count == 3)
            {
                IDsNodeMapperDic.Remove(list.Head.Number);
                list.Remove(list.Head);
            }

            IDsNodeMapperDic[id] = list.Add(id);
        }
        public static int GetRecentViewedMovie()
        {
            return list.Tail.Number;
        }
    }
}

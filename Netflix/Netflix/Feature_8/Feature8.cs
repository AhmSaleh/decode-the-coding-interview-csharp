namespace Netflix.Feature_8
{
    public static class Feature8
    {
        public static bool IsSessionValid(List<int> pushOperations, List<int> popOperations)
        {

            Stack<int> stack = new();
            int index = 0;

            foreach (var push in pushOperations)
            {
                if (push != popOperations[index])
                {
                    stack.Push(push);
                }
                else
                {
                    index++;
                }
            }

            foreach (var pop in popOperations.Skip(index))
            {
                if (stack.Peek() == pop)
                    stack.Pop();
            }


            return (stack.Count == 0);
        }
    }
}

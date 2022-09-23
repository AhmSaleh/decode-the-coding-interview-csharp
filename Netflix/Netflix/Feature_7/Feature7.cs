namespace Netflix.Feature_7
{
    public static class Feature7
    {
        private static Stack<int> MainStack;
        private static Stack<int> MaxStack;
        public static int MaxValue
        {
            get
            {
                return MaxStack.Peek();
            }
        }

        static Feature7()
        {
            MainStack = new();
            MaxStack = new();
        }

        public static void push(int value)
        {
            MainStack.Push(value);

            if (MaxStack.Count == 0 || MaxStack.Peek() < value)
                MaxStack.Push(value);
            else
                MaxStack.Push(MaxStack.Peek());

        }
        public static int Back()
        {
            MaxStack.Pop();
            return MainStack.Pop();
        }

    }
}

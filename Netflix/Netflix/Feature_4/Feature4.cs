namespace Netflix.Feature_4
{
    public static class Feature4
    {
        public static bool identifyTitles(List<int> titles)
        {
            if (titles.Count == 0)
                throw new Exception("Titles count must be more than one!");

            bool isIncreasing = true;
            bool isDecreasing = true;
            int last = titles[0];

            foreach (var title in titles.Skip(1))
            {
                if (last < title)
                    isDecreasing = false;

                if (last > title)
                    isIncreasing = false;
            }

            return (isIncreasing || isDecreasing);
        }
    }
}

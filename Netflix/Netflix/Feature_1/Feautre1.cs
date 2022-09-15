namespace Netflix.Feature_1
{
    public static class Feautre1
    {
        public static Dictionary<int, List<string>> getAnagramDict(List<string> titles)
        {
            Dictionary<int, List<string>> map = new();

            foreach (var title in titles)
            {
                if (!map.ContainsKey(getTitleBits(title)))
                {
                    map[getTitleBits(title)] = new();
                }

                map[getTitleBits(title)].Add(title);
            }

            return map;
        }

        private static int getTitleBits(string title)
        {
            int bits = 0;
            int mask;
            int c;

            for (int i = 0; i < title.Length; i++)
            {
                c = title[i] - 'a';

                mask = 1;
                mask <<= c;

                bits |= mask;
            }

            return bits;
        }
    }

}

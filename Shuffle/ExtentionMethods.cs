namespace Shuffle
{
    using System.Collections.Generic;
    using System.Linq;
    using System;
    //Adding random comment
    public static class ExtensionMenthods
    {
        public static IEnumerable<TSource> Shuffle<TSource>(this IEnumerable<TSource> input)
        {
            Random rnd = new Random();

            int uBound = input.Count() - 1;
            int maxVal = uBound;
            int ind;

            List<TSource> inputList = input.ToList();
            List<int> indexList = new List<int>(uBound + 1);
            List<TSource> returnList = new List<TSource>(uBound + 1);

            for (int i = 0; i <= uBound; i++) indexList.Add(i);
            for (int i = 0; i <= uBound; i++)
            {
                ind = rnd.Next(maxVal);
                returnList.Add(inputList[indexList[ind]]);
                indexList.RemoveAt(ind);
                maxVal--;
            }

            return returnList;

        }
    }
}

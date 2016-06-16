using System;

namespace _3.GenericList
{
    public static class AdditionalGenericListMethods
    {
        public static T Min<T>(this GenericList<T> list) where T : IComparable
        {
            T minimalElement = list.AccessElement(0);

            for (int i = 0; i < list.Count; i++)
            {
                if (list.AccessElement(i).CompareTo(minimalElement) < 0)
                {
                    minimalElement = list.AccessElement(i);
                }
            }
            return minimalElement;
        }

        public static T Max<T>(this GenericList<T> list) where T : IComparable
        {
            T maximalElement = list.AccessElement(0);

            for (int i = 0; i < list.Count; i++)
            {
                if (list.AccessElement(i).CompareTo(maximalElement) > 0)
                {
                    maximalElement = list.AccessElement(i);
                }
            }
            return maximalElement;
        }
    }
}

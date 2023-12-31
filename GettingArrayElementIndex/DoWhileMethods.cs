﻿namespace GettingArrayElementIndex
{
    public static class DoWhileMethods
    {
        public static int GetIndexOf(ulong[]? arrayToSearch, ulong value)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (arrayToSearch.Length == 0)
            {
            return -1;
            }

            int index = 0;

            do
            {
                if (arrayToSearch[index] == value)
                {
                return index;
                }

                index++;
            }
            while (index < arrayToSearch.Length);

            return -1;
        }

        public static int GetIndexOf(ulong[]? arrayToSearch, ulong value, int startIndex, int count)
        {
            if (arrayToSearch == null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch), "The arrayToSearch argument cannot be null.");
            }

            if (startIndex < 0 || startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "The startIndex argument is out of range.");
            }

            if (count < 0 || startIndex + count > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "The count argument is out of range.");
            }

            if (arrayToSearch.Length == 0)
            {
                return -1;
            }

            int index = startIndex;

            do
            {
                if (arrayToSearch[index] == value)
                {
                return index;
                }

                index++;
                count--;
            }
            while (count > 0);

            return -1;
        }

        public static int GetLastIndexOf(ulong[]? arrayToSearch, ulong value)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int i = arrayToSearch.Length - 1;
            if (i < 0)
            {
                return -1;
            }

            do
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }
            while (--i >= 0);

            return -1;
        }

        public static int GetLastIndexOf(ulong[]? arrayToSearch, ulong value, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater than arrayToSearch.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            int lastIndex = startIndex + count;
            if (lastIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            int i = lastIndex - 1;
            if (i < 0)
            {
                return -1;
            }

            do
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }
            }
            while (--i >= startIndex);

            return -1;
        }
    }
}

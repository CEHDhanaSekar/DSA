namespace DSA.Algorithms.Searching;

public class BinarySearch
{
    public static int Search(int[] arr, int target)
    {
        int start = 0;
        int end = arr.Length - 1;

        bool isAsc = arr[start] < arr[end];

        while(start <= end)
        {
            int mid = (start + end) / 2;
            if (arr[mid] == target)
                return mid;

            if(isAsc)
            {
                if (arr[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            else
            {
                if (arr[mid] > target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }        
        }

        return -1;
    }

    public static bool Contains(int[] arr, int target)
    {
        int start = 0;
        int end = arr.Length - 1;

        bool isAsc = arr[start] < arr[end];

        while (start <= end)
        {
            int mid = (start + end) / 2;
            if (arr[mid] == target)
                return true;

            if (isAsc)
            {
                if (arr[mid] < target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            else
            {
                if (arr[mid] > target)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
        }

        return false;
    }
}

namespace DSA.Algorithms.Searching;

public class LinearSearch
{
    public static int Search(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == target) return i;

        return -1;
    }

    public static bool Contains(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == target) return true;

        return false;
    }

    public static int Search(string str, char target)
    {
        for (int i = 0; i < str.Length; i++)
            if (str[i] == target) return i;

        return -1;
    }

    public static bool Contains(string str, char target)
    {
        for (int i = 0; i < str.Length; i++)
            if (str[i] == target) return true;

        return false;
    }

    public static int Search(string[] strArr, string target)
    {
        for (int i = 0; i < strArr.Length; i++)
            if (strArr[i] == target) return i;

        return -1;
    }

    public static bool Contains(string[] strArr, string target)
    {
        for (int i = 0; i < strArr.Length; i++)
            if (strArr[i] == target) return true;

        return false;
    }


    // 2D Array Search
    public static int[] Search(int[][] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; i++)
            {
                if (arr[i][j] == target) return [i, j];
            }
        }

        return [-1, -1];
    }

    public static int[] Search(string[][] arr, string target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; i++)
            {
                if (arr[i][j] == target) return [i, j];
            }
        }

        return [-1, -1];
    }
}

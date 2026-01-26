namespace DSA.Algorithms.Sorting;

public class Sort
{
    public Sort() { }

    public int[] SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIdx = i;

            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minIdx])
                {
                    minIdx = j;
                }
            }

            int temp = arr[i];
            arr[i] = arr[minIdx];
            arr[minIdx] = temp;
        }
        return arr;
    }

    public int[] BubbleSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    var temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        return arr;
    }

    public int[] InsertionSort(int[] arr)
    {
        for(int i = 0; i < arr.Length - 1; i++)
        {
            for(int j = i + 1; j > 0; j--)
            {
                if (arr[j] >= arr[j-1])
                {
                    break;
                }
                var temp = arr[j - 1];
                arr[j - 1] = arr[j];
                arr[j] = temp;
            }
        } 
        return arr;
    }
}

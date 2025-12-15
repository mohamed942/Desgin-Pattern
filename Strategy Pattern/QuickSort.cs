namespace Strategy_Pattern;

public class QuickSort : ISortStrategy
{
    public void Sort(int[] numbers)
    {
        if (numbers == null || numbers.Length <= 1)
            return;

        QuickSortRange(numbers, 0, numbers.Length - 1);
    }

    private void QuickSortRange(int[] a, int low, int high)
    {
        if (low < high)
        {
            int p = Partition(a, low, high);
            QuickSortRange(a, low, p - 1);
            QuickSortRange(a, p + 1, high);
        }
    }

    // Lomuto partition scheme
    private int Partition(int[] a, int low, int high)
    {
        int pivot = a[high];
        int i = low;
        for (int j = low; j < high; j++)
        {
            if (a[j] < pivot)
            {
                Swap(a, i, j);
                i++;
            }
        }
        Swap(a, i, high);
        return i;
    }

    private static void Swap(int[] a, int i, int j)
    {
        if (i == j) return;
        int tmp = a[i];
        a[i] = a[j];
        a[j] = tmp;
    }
}



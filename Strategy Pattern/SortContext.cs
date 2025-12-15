namespace Strategy_Pattern;

public class SortContext
{
    private ISortStrategy _sortStrategy;

    public SortContext(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void SetSortStrategy(ISortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }
    public void PerformSort(int[] numbers)
    {
        _sortStrategy.Sort(numbers);
    }

    public void PrintArray(int[] numbers)
    {
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    
}



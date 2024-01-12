using System;
using System.Diagnostics;

class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;

    public DateTime StartTime
    {
        get { return startTime; }
    }

    public DateTime EndTime
    {
        get { return endTime; }
    }

    public StopWatch()
    {
        startTime = DateTime.Now;
        endTime = DateTime.Now;
    }

    public void Start()
    {
        startTime = DateTime.Now;
    }

    public void Stop()
    {
        endTime = DateTime.Now;
    }

    public long GetElapsedTime()
    {
        TimeSpan elapsed = endTime - startTime;
        return (long)elapsed.TotalMilliseconds;
    }
}

class SelectionSort
{
    static void Main()
    {
        const int arraySize = 100000;
        int[] arr = new int[arraySize];
        Random random = new Random();

        // Initialize array with random values
        for (int i = 0; i < arraySize; i++)
        {
            arr[i] = random.Next();
        }

        StopWatch timer = new StopWatch();  // Fix the typo here
        SelectionSortAlgorithm(arr);
        timer.Stop();

        Console.WriteLine($"Selection Sort for {arraySize} elements took {timer.GetElapsedTime()} milliseconds.");
    }

    static void SelectionSortAlgorithm(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}

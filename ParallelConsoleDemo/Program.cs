using System.Diagnostics;

int repetitions = 50;

Console.WriteLine($"Reading file {repetitions} times...");

// --- TEST 1: Using sequential mode with the stopwatch  ---
Console.WriteLine("Test 1: Sequential read with Stopwatch");
var sw = Stopwatch.StartNew();

for (int i = 0; i < repetitions; i++)
{
    ReadFile(i + 1);
}

sw.Stop();
Console.WriteLine($"Sequential read time: {sw.Elapsed.TotalSeconds} s");

// --- TEST 2: Using parallel mode with the stopwatch  ---
Console.WriteLine("Test 1: Parallel read with Stopwatch");
sw.Restart();

Parallel.ForEach(Enumerable.Range(1, repetitions), i =>
{
    ReadFile(i);
});

sw.Stop();
double parallelTime = sw.Elapsed.TotalSeconds;
Console.WriteLine($"Parallel read time: {parallelTime} s");

static void ReadFile(int interaction)
{
    string filePath = "CleanCode.pdf";

    if (!File.Exists(filePath))
    {
        Console.WriteLine($"File '{filePath}' not found");
        return;
    }

    try
    {
        byte[] data = File.ReadAllBytes(filePath);
        long sum = 0;

        foreach (var b in data)
        {
            sum += b;
        }

        Console.WriteLine($"Interaction {interaction}: Read {data.Length} bytes, sum: {sum}");
    } catch (Exception ex)
    {
        Console.WriteLine($"Error reading file: {ex.Message}");
    }
}
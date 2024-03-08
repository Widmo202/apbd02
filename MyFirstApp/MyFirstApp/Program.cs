// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modification 1");
Console.WriteLine("Modification 2");
Console.WriteLine("Modification 3");

static double GetAvg(int[] arr)
{
    double avg = 0;
    foreach (var a in arr)
    {
        avg += a;
    }

    return avg / arr.Length;
}
int[] numbers = new []{1,2,3,4};

double avg = GetAvg(numbers);
Console.WriteLine(avg);
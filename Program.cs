namespace Homework4;

internal class Program
{
    static void Main(string[] args)
    {
        TemperatureArray t = new TemperatureArray();
        t.Show();
        t.InputTemp();
        t.Show();
        Console.WriteLine($"average: {t.TempAverage()}");
    }
}

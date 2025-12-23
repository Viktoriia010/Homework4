namespace Homework4;

internal class Program
{
    static void Main(string[] args)
    {
        //TemperatureArray t = new TemperatureArray();
        //t.Show();
        //t.InputTemp();
        //t.Show();
        //Console.WriteLine($"average: {t.TempAverage()}");

        Product apple = new Product("Apple", 10, 100);
        Product banana = new Product("Banana", 8, 50);

        apple.Show();
        banana.Show();

        apple += 5;
        apple -= 3;
        banana -= 8;

        apple.Show();
        banana.Show();

        Console.WriteLine(apple > banana);
        Console.WriteLine(apple < banana);
        Console.WriteLine(apple == banana);
        Console.WriteLine(apple != banana);
    }
}

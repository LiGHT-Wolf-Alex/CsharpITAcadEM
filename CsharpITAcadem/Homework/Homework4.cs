namespace CsharpITAcadem.Homework;

public class Homework4 : IHomework
{
    public void FirstExercise()
    {
        Console.Write("Enter the number of array elements => ");
        int.TryParse(Console.ReadLine(), out var arraySIze);

        if (arraySIze < 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Array size must be greater than 2!");
            Console.ForegroundColor = default;
            return;
        }

        var myArray = new int[arraySIze];
        {
            var random = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(-100, 100);
                Console.Write($"{myArray[i]}; ");
            }
        }

        int sum = 0;
        foreach (var item in myArray)
        {
            sum += item;
        }

        Console.WriteLine($"\r\nSum of all array elements => {sum}");
    }

    public void SecondExercise()
    {
    }

    public void ThirdExercise()
    {
    }

    public void FourthExercise()
    {
    }
}
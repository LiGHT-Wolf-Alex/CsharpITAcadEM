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
        Console.Write("Enter the number of array elements => ");
        int.TryParse(Console.ReadLine(), out var arraySIze);

        var myArray = new float [arraySIze];
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"[{i}] = ");
            float.TryParse(Console.ReadLine(), out myArray[i]);
        }

        float max = myArray[0], min = myArray[0];

        for (int i = 1; i < myArray.Length; i++)
        {
            if (max < myArray[i])
            {
                max = myArray[i];
                continue;
            }

            if (min > myArray[i])
            {
                min = myArray[i];
            }
        }

        Console.WriteLine($"max = {max}; min = {min}");
        Console.WriteLine($"Difference between maximum and minimum in an array => {max - min}");
    }

    public void ThirdExercise()
    {
    }

    public void FourthExercise()
    {
    }
}
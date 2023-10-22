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
        var myArray = new int[] { 23, 43, 5, 2, 5, 23, 6, 9, 23, 23, 5, 3, 6, 32 };

        Console.Write("Array => ");
        foreach (var i in myArray)
        {
            Console.Write($"[{i}]; ");
        }

        Console.WriteLine();

        bool isAllElementsUnique = true;

        Array.Sort(myArray);
        for (int i = 0, quantity; i < myArray.Length; i++)
        {
            quantity = 1;
            while ((i + 1 < myArray.Length) && (myArray[i] == myArray[i + 1]))
            {
                quantity++;
                i++;
            }

            if (quantity != 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{myArray[i - 1]} repeat => {quantity} ");
                isAllElementsUnique = false;
            }
        }

        if (isAllElementsUnique)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All elements are unique.");
        }
    }

    public void FourthExercise()
    {
    }
}
namespace AlgorithmQuestions;
class Program
{
    static void Main(string[] args)
    {
        // First Question
        QuestionOne();

        // Second Question
        QuestionTwo();

        // Third Question
        QuestionThree();

        // Fourth question
        QuestionFour();

    }

    private static void QuestionFour()
    {
        Console.WriteLine("4-)");
        Console.Write("Please write a sentence : ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(" ");

        int countWord = 0;
        int countLetter = 0;

        foreach (var word in words)
        {
            countLetter += word.Length;
            countWord++;
        }
        Console.WriteLine("Number of words = " + countWord);
        Console.WriteLine("Number of letters = " + countLetter);
    }

    private static void QuestionThree()
    {
        Console.WriteLine("3-)");
        Console.Write("Please enter a positive number : ");
        int n = int.Parse(Console.ReadLine());

        string[] words = new string[n];
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Please enter the {i}. word : ");
            words[i - 1] = Console.ReadLine();
        }
        Array.Reverse(words);

        Console.WriteLine("Back to front :");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }

    private static void QuestionTwo()
    {
        Console.WriteLine("2-)");
        Console.Write("Please enter the first number : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second number : ");
        int m = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Please enter the {i}. number : ");
            numbers[i - 1] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Numbers that are equal to or evenly divisible by the 2nd number :");
        foreach (var number in numbers)
        {
            if (number == m || number % m == 0)
            {
                Console.WriteLine(number);
            }
        }
    }

    private static void QuestionOne()
    {
        Console.WriteLine("1-)");
        Console.Write("Please enter a positive number : ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Please enter the {i}. number : ");
            numbers[i - 1] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Even numbers : ");
        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }
}

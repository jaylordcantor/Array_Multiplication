public class Program
{

    public static void Main(string[] args)
    {
        
        while (true)
        {
            Console.WriteLine("Enter a comma-separated list of numbers:");
            string inputString = Console.ReadLine();
            string[] inputArray = inputString.Split(',');
            int[] input = Array.ConvertAll(inputArray, int.Parse);
            
            Compute(input);
            Console.WriteLine();
        }
       
    }

    public static void Compute(int[] input)
    {
        int[] result = new int[input.Length];
        int product = 1;
        for (int i = 0; i < input.Length; i++)
        {
            result[i] = product;
            product *= input[i];
        }

        product = 1;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            result[i] *= product;
            product *= input[i];
        }

        foreach (int num in result)
        {
            Console.Write(num + ", ");
        }
    }
}
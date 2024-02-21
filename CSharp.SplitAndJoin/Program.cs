namespace CSharp.SplitAndJoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number with comma: ");
            string input = Console.ReadLine();
            string[] arr = input.Split(",");
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += int.Parse(arr[i]);
            }
            double Avg = sum / arr.Length;
            Console.WriteLine(Avg);
            Console.WriteLine("***********************");

            //join
            string[] arr2 = { "Ahmed", "Mohamed", "Abdou" };
            string statment = string.Join(" ", arr2);
            Console.WriteLine(statment);
        }
    }
}

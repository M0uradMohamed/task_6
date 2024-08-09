namespace genericsMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
             bool IsEqual = ClsCalculator.AreEqual(10, 20);
            // bool IsEqual = ClsCalculator.AreEqual("ABC", "ABC");
           // bool IsEqual = ClsCalculator.AreEqual(10.5, 20.5);
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }

        }
    }
}

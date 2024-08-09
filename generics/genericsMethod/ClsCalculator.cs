namespace genericsMethod
{
    public class ClsCalculator
    {

    public static bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
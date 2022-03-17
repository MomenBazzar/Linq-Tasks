namespace LINQ
{
    public delegate int TransformationFunction (int number);
    public static class Transformation
    {
        public static IEnumerable<int> Transform(this IEnumerable<int> numbers, TransformationFunction func)
        {
            foreach(var num in numbers)
            {
                yield return func(num);
            }
        }
    }
}
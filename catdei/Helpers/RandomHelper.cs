namespace Catdei.Helpers
{
    public static class RandomHelper
    {
        private static readonly Random _random = new Random();

        public static T GetRandomElement<T>(IEnumerable<T> enumerable)
        {
            if (enumerable.Count() == 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int index = _random.Next(enumerable.Count());
            return enumerable.ElementAt(index);
        }
    }
}
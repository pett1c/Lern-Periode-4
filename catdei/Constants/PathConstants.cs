namespace Catdei.Constants
{
    public static class PathConstants
    {
        public static IEnumerable<string> FridayPaths => 
            Directory.GetFiles(Path.Combine(_imagesFolder, "Friday"));
        public static IEnumerable<string> MondayPaths =>
            Directory.GetFiles(Path.Combine(_imagesFolder, "Monday"));
        public static IEnumerable<string> OtherPaths =>
            Directory.GetFiles(Path.Combine(_imagesFolder, "Other"));

        private static readonly string _imagesFolder = Path.Combine(Directory.GetCurrentDirectory(), "Images");
    }
}

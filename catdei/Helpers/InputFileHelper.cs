using InputFile = Telegram.Bot.Types.InputFile;

namespace Catdei.Helpers
{
    public static class InputFileHelper
    {
        public static InputFile FromPath(string path)
        {
            Stream stream = File.OpenRead(path);
            return InputFile.FromStream(stream);
        }
    }
}

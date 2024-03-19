using Catdei.Constants;
using Catdei.Helpers;
using System.ComponentModel;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Catdei
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ITelegramBotClient botClient = new TelegramBotClient(ApiConstants.Token);
            botClient.StartReceiving(Update, HandleError);

            Console.WriteLine("Бот запущен.");

            DateTime lastSentTime = DateTime.Now;

            while (true)
            {
                DateTime now = DateTime.Now;
                string imagePath = GetImagePath(now.DayOfWeek);
                InputFile image = InputFileHelper.FromPath(imagePath);

                if (IsCooldownElapsed(now, lastSentTime, BotConstants.ImageSendCooldown)) 
                {
                    botClient.SendPhotoAsync(ApiConstants.ChatId, image).GetAwaiter().GetResult();
                }
                else 
                {
                    lastSentTime = now;
                }

                Thread.Sleep(1000);
            }
        }

        private static string GetImagePath(DayOfWeek dayOfWeek) 
        {
            IEnumerable<string> paths = GetImagePaths(dayOfWeek);
            return RandomHelper.GetRandomElement(paths);
        }

        private static IEnumerable<string> GetImagePaths(DayOfWeek dayOfWeek) 
        {
            if (dayOfWeek == DayOfWeek.Monday) 
            {
                return PathConstants.MondayPaths;
            }
            else if (dayOfWeek == DayOfWeek.Friday) 
            {
                return PathConstants.FridayPaths;
            }
            else
            {
                return PathConstants.OtherPaths;
            }
        }

        private static Task HandleError(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            Console.WriteLine(exception);
            return Task.CompletedTask;
        }

        private static async Task HandleMessage(ITelegramBotClient client, Message message)
        {
            if (message.Text == "/start")
            {
                await client.SendTextMessageAsync(message.Chat.Id, "Привет! Я бот для отправки картинок.");
            }
        }

        private static bool IsCooldownElapsed(DateTime now, DateTime lastTime, TimeSpan cooldown) 
        {
            double elapsedTimeInHours = (now - lastTime).TotalHours;
            double cooldownInHours = cooldown.TotalHours;

            return elapsedTimeInHours > cooldownInHours;
        }

        private static async Task Update(ITelegramBotClient client, Update update, CancellationToken token)
        {
            Message? message = update.Message;

            if (message != null)
            {
                await HandleMessage(client, message);
            }
        }
    }
}
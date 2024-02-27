using System;
using System.Security.Cryptography.X509Certificates;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace RABEBBOT

{
    internal class Program
    {

        static void Main(string[] args)
        {
            var client = new TelegramBotClient("7099629430:AAE9nsg7Wd3DIkCzYUzLbfoxMNg2-IF-RwE");
            client.StartReceiving(Update, Error);
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }

        async static Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var message = update.Message;
            if (message.Text != null)
            {
                Console.WriteLine($"{message.Chat.FirstName} | {message.Text}");
                if (message.Text.Equals("/start"))
                {
                    await botClient.SendTextMessageAsync(message.Chat.Id, "Привет, меня зовут RABEB, и я помогу тебе с настройкой твоего графика дня. Как к тебе обращаться?");
                }
            }
        }

        private static Task Error(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }

}


//else if (message.Text.ToLower().Contains("..."))
//{
//    await botClient.SendTextMessageAsync(message.Chat.Id, "Доброго! Я бот, который поможет тебе с найстрокой распорядка дня. ");
//    return;
//}